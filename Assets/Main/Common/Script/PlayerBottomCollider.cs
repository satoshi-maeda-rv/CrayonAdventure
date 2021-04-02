using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBottomCollider : MonoBehaviour
{
    // 乗ったプレイヤー
    GameObject ridePlayerMover;

    // 乗ったプレイヤーのスクリプト
    RidePlayerMove script;

    void Start()
    {
        // 乗った時に動作する物の名称を入れておく
        ridePlayerMover = GameObject.Find("RidePlayerMover");
        script = ridePlayerMover.GetComponent<RidePlayerMove>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "BottomCollider")
        {
            script.objName = collider.transform.parent.gameObject.name;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "BottomCollider")
        {
            script.objName = "none";
        }
    }
}
