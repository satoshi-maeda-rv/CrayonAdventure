using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 重力を右に変更
public class ChangeGravityLeft : MonoBehaviour
{
    // ワイド君取得
    GameObject wide;

    MovePrayer wideScript;

    // トールちゃん取得
    GameObject tall;

    MovePrayer tallScript;

    void Start()
    {
        wide = GameObject.Find("wide");
        tall = GameObject.Find("tall");
        wideScript = wide.GetComponent<MovePrayer>();
        tallScript = tall.GetComponent<MovePrayer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        wideScript.gravityDirection = 3;
        tallScript.gravityDirection = 3;

        Physics2D.gravity = new Vector2(0.0f, 0.0f);

        Destroy (gameObject);
    }
}
