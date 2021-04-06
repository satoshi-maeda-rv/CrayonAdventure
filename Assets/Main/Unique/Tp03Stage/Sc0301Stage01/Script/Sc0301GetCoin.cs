using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc0301GetCoin : MonoBehaviour
{
    // 旗と旗のスクリプト取得
    GameObject flag;

    Sc0301GoalFlag goalFlagScript;

    //起動
    void Start()
    {
        flag = GameObject.Find("Flag");
        goalFlagScript = flag.GetComponent<Sc0301GoalFlag>();
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
