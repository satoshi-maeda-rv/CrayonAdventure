using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravityRight : MonoBehaviour
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
        Physics2D.gravity = new Vector2(9.8f, 0.0f);

        wide.transform.Rotate(0, 0, 90f);
        tall.transform.Rotate(0, 0, 90f);

        wideScript.gravityDirection = 1;
        tallScript.gravityDirection = 1;

        Destroy (gameObject);
    }
}
