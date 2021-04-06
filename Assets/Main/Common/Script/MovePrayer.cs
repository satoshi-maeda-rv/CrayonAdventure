using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrayer : MonoBehaviour
{
    public enum GravityDirection
    {
        down = 0,
        right = 1,
        up = 2,
        left = 3
    }

    // 最高速度
    public float maxSpeed;

    // 加速度
    public float addSpeed;

    // ジャンプ時の加算速度
    public float jumpAddSpeed;

    // ジャンプ可能かどうかの判定
    public int jumpCount = -1;

    // ジャンプするクラス
    Jump jumpClass = new Jump();

    // 重力方向
    // 0下、1右、2上、3左
    public int gravityDirection = 0;

    // 操作キャラか判定
    public bool Player;

    // Rigidbody2D格納
    private Rigidbody2D rb;

    // ジャンプできるカウント数
    private int canJumpCount = 2;

    // 初期化
    void Start()
    {
        // オブジェクトのrigidbodyの取得
        rb = GetComponent<Rigidbody2D>();
    }

    // 更新時に実行
    void FixedUpdate()
    {
        // Zボタンでキャラの変更
        if (Input.GetKeyUp(KeyCode.Z))
        {
            Player = !Player;
        }

        RotateChara
            .GetInstance()
            .moveChara(this.gameObject, rb, gravityDirection);

        // 跳躍中ではないときにジャンプできる数値を回復する
        if (
            (gravityDirection == 0 || gravityDirection == 2) &&
            Mathf.Abs(rb.velocity.y) < 0.01 &&
            jumpCount < canJumpCount
        )
        {
            jumpCount += 1;
        }
        else if (
            (gravityDirection == 1 || gravityDirection == 3) &&
            Mathf.Abs(rb.velocity.x) < 0.01 &&
            jumpCount < canJumpCount
        )
        {
            jumpCount += 1;
        }

        // もしもプレイヤーだったら動かせるように
        if (Player)
        {
            // 押下矢印によってキャラの移動
            MoveCharaArrowPush
                .GetInstance()
                .moveChara(rb, gravityDirection, maxSpeed, addSpeed);

            // ジャンプ実行
            jumpCount =
                jumpClass
                    .tapJumpButton(rb,
                    gravityDirection,
                    jumpCount,
                    jumpAddSpeed,
                    canJumpCount);
        }
    }
}
