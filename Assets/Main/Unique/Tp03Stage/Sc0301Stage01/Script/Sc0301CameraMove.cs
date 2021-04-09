using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc0301CameraMove : MonoBehaviour
{
    // メインカメラ
    GameObject mainCamera;

    // ワイド
    private string nameWide = "wide";

    // トール
    private string nameTall = "tall";

    // カメラ移動するかどうか？
    private bool moveCamera = false;

    // 始めに当たったキャラの名前
    public string firstCharaName = "none";

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void FixedUpdate()
    {
        if (moveCamera)
        {
            if (mainCamera.transform.position.x < -13)
            {
                mainCamera.transform.position =
                    mainCamera.transform.position + new Vector3(0.1f, 0, 0);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.transform.parent.gameObject.name);
        if (collider.transform.parent.gameObject.tag == "player")
        {
            if (collider.transform.parent.gameObject.name == nameWide)
            {
                if (firstCharaName == nameTall)
                {
                    moveCamera = true;
                }
                else
                {
                    firstCharaName = nameWide;
                }
            }
            else if (collider.transform.parent.gameObject.name == nameTall)
            {
                if (firstCharaName == nameWide)
                {
                    moveCamera = true;
                }
                else
                {
                    firstCharaName = nameTall;
                }
            }
        }
    }
}
