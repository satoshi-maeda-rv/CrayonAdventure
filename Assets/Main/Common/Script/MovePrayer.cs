using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrayer : MonoBehaviour
{
    // 最高速度
    public float maxSpeed;

    // 加速度
    public float addSpeed;

    // ジャンプ時の加算速度
    public float jumpAddSpeed;

    // ジャンプ可能かどうかの判定
    public int jumpCount = -1;

    Jump jumpClass = new Jump();

    // 操作キャラか判定
    public bool Player;

    // Rigidbody2D格納
    private Rigidbody2D rb;

    // ジャンプできるカウント数
    private int canJumpCount = 5;

    public float canJumpHight = 4f;

    // 初期化
    void Start()
    {
        // オブジェクトのrigidbodyの取得
        rb = GetComponent<Rigidbody2D>();
    }

    // 更新時に実行
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            Player = !Player;
        }

        if (Mathf.Abs(rb.velocity.y) < 0.00001 && jumpCount < canJumpCount)
        {
            jumpCount += 1;
        }

        if (Player)
        {
            // 現在のX軸速度
            float velocityX = rb.velocity.x;

            //右入力で右向きに動く
            if (Input.GetKey(KeyCode.RightArrow))
            {
                // 速度が最高速度ではない場合
                if (velocityX < maxSpeed)
                {
                    // 初速はつける
                    if (velocityX == 0)
                    {
                        rb.velocity = new Vector2(1.0f, rb.velocity.y);
                    }
                    rb.velocity =
                        new Vector2(rb.velocity.x + addSpeed, rb.velocity.y);
                }
            } // 左ボタンを押したら左に動く
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                // 速度が最高速度ではない場合
                if (velocityX > -maxSpeed)
                {
                    // 初速はつける
                    if (velocityX == 0)
                    {
                        rb.velocity = new Vector2(-1.0f, rb.velocity.y);
                    }
                    rb.velocity =
                        new Vector2(rb.velocity.x - addSpeed, rb.velocity.y);
                }
            }
            else
            //ボタンを離すと止まる
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }

            jumpCount =
                jumpClass
                    .tapJumpButton(rb, jumpCount, jumpAddSpeed, canJumpCount);
        }
    }
}
