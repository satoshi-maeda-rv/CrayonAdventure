﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 重力を上に変更
public class ChangeGravityUp : MonoBehaviour
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
        wideScript.gravityDirection = 2;
        tallScript.gravityDirection = 2;

        Physics2D.gravity = new Vector2(0.0f, 0.0f);

        Destroy (gameObject);
    }
}
