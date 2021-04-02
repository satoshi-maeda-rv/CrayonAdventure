using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// キャラが上に載っているときの上のキャラの動き
public class RidePlayerMove : MonoBehaviour
{
    // ワイドオブジェクト
    GameObject wide;

    // ワイドのrigidbody2D
    Rigidbody2D rbWide;

    // トールオブジェクト
    GameObject tall;

    // トールのrigidbody2D
    Rigidbody2D rbTall;

    // ワイドのスクリプト
    MovePrayer wideScript;

    // トールのスクリプト
    MovePrayer tallScript;

    // 跳躍時加算する加速度
    public float jumpAddSpeed;

    // 上に乗ったオブジェクト名
    public string objName;

    Jump jumpClass = new Jump();

    void Start()
    {
        wide = GameObject.Find("wide");
        rbWide = wide.GetComponent<Rigidbody2D>();
        wideScript = wide.GetComponent<MovePrayer>();
        tall = GameObject.Find("tall");
        rbTall = tall.GetComponent<Rigidbody2D>();
        tallScript = tall.GetComponent<MovePrayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objName == "wide" && !wideScript.Player)
        {
            rbWide.velocity = new Vector2(rbTall.velocity.x, rbTall.velocity.y);

            int jumpCount =
                jumpClass
                    .tapJumpButton(rbWide,
                    wideScript.gravityDirection,
                    5,
                    jumpAddSpeed,
                    5);
        }
        else if (objName == "tall" && !tallScript.Player)
        {
            rbTall.velocity = new Vector2(rbWide.velocity.x, rbWide.velocity.y);

            int jumpCount =
                jumpClass
                    .tapJumpButton(rbTall,
                    tallScript.gravityDirection,
                    5,
                    jumpAddSpeed,
                    5);
        }
    }
}
