using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MoveCharaArrowPush
{
    public static MoveCharaArrowPush GetInstance()
    {
        return new MoveCharaArrowPush();
    }

    public void moveChara(
        Rigidbody2D rb,
        // 重力方向
        // 0下、1右、2上、3左
        int gravityDirection,
        float maxSpeed,
        float addSpeed
    )
    {
        // 押した矢印の方向を記憶する
        float pushArrowDirection = 0.0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pushArrowDirection = 1.0f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            pushArrowDirection = -1.0f;
        }
        else
        {
            pushArrowDirection = 0;
        }

        // X軸速度
        float velocityX = rb.velocity.x;

        // Y軸速度
        float velocityY = rb.velocity.y;

        //右入力で右向きに動く
        {
            switch (gravityDirection)
            {
                case 0:
                    // 入力がなければ速度を落とす
                    if (pushArrowDirection == 0.0f)
                    {
                        rb.velocity = new Vector2(0, velocityY);
                    }
                    else if (Mathf.Abs(velocityX) < maxSpeed)
                    {
                        // 重力下向き
                        // 初速をつける
                        if (velocityX == 0)
                        {
                            rb.velocity =
                                new Vector2(1.0f * pushArrowDirection,
                                    velocityY);
                        }
                        rb.velocity =
                            new Vector2(velocityX +
                                addSpeed * pushArrowDirection,
                                velocityY);
                    }
                    break;
                case 1:
                    // 入力がなければ速度を落とす
                    if (pushArrowDirection == 0.0f)
                    {
                        rb.velocity = new Vector2(velocityX, 0);
                    }
                    else if (Mathf.Abs(velocityY) < maxSpeed)
                    {
                        // 重力右向き
                        // 初速をつける
                        if (velocityY == 0)
                        {
                            rb.velocity =
                                new Vector2(velocityX,
                                    1.0f * pushArrowDirection);
                        }
                        rb.velocity =
                            new Vector2(velocityX,
                                velocityY + addSpeed * pushArrowDirection);
                    }
                    break;
                case 2:
                    // 入力がなければ速度を落とす
                    if (pushArrowDirection == 0.0f)
                    {
                        rb.velocity = new Vector2(0, velocityY);
                    }
                    else if (Mathf.Abs(velocityX) < maxSpeed)
                    {
                        // 重力上向き
                        // 初速をつける
                        if (velocityX == 0)
                        {
                            rb.velocity =
                                new Vector2(-1.0f * pushArrowDirection,
                                    velocityY);
                        }
                        rb.velocity =
                            new Vector2(velocityX +
                                addSpeed * pushArrowDirection,
                                velocityY);
                    }
                    break;
                case 3:
                    // 入力がなければ速度を落とす
                    if (pushArrowDirection == 0.0f)
                    {
                        rb.velocity = new Vector2(velocityX, 0);
                    }
                    else if (Mathf.Abs(velocityY) < maxSpeed)
                    {
                        // 重力左向き
                        // 初速をつける
                        if (velocityY == 0)
                        {
                            rb.velocity =
                                new Vector2(velocityX,
                                    -1.0f * pushArrowDirection);
                        }
                        rb.velocity =
                            new Vector2(velocityX,
                                velocityY + -addSpeed * pushArrowDirection);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
