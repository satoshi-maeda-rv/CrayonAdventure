using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc0305GetCoin : MonoBehaviour
{
    // 旗と旗のスクリプト取得
    GameObject flag;

    Sc0305GoalFlag goalFlagScript;

    //起動
    void Start()
    {
        flag = GameObject.Find("Flag");
        goalFlagScript = flag.GetComponent<Sc0305GoalFlag>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "SideCollider")
        {
            goalFlagScript.coinsCount += 1;
            Destroy (gameObject);
        }
    }
}
