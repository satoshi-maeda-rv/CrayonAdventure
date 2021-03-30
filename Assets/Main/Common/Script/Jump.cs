using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jump
{
    public float startJumpPos = 0f;

    public int
    tapJumpButton(
        Rigidbody2D rb,
        int gravityDirection,
        int jumpCount,
        float jumpAddSpeed,
        int canJumpCount
    )
    {
        // 取り直す
        float velocityX = rb.velocity.x;
        float velocityY = rb.velocity.y;

        // ジャンプ処理
        if (Input.GetKey(KeyCode.X))
        {
            if (jumpCount == canJumpCount)
            {
                switch (gravityDirection)
                {
                    case 0:
                        rb.velocity = new Vector2(velocityX, jumpAddSpeed);
                        break;
                    case 1:
                        rb.velocity = new Vector2(-jumpAddSpeed, velocityY);
                        break;
                    case 2:
                        rb.velocity = new Vector2(velocityX, -jumpAddSpeed);
                        break;
                    case 3:
                        rb.velocity = new Vector2(jumpAddSpeed, velocityY);
                        break;
                    default:
                        break;
                }

                return canJumpCount + 2;
            }
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            switch (gravityDirection)
            {
                case 0:
                    if (rb.velocity.y > 0)
                    {
                        rb.velocity = new Vector2(velocityX, velocityY / 3);
                    }
                    break;
                case 1:
                    if (rb.velocity.x < 0)
                    {
                        rb.velocity = new Vector2(velocityX / 3, velocityY);
                    }
                    break;
                case 2:
                    if (rb.velocity.y < 0)
                    {
                        rb.velocity = new Vector2(velocityX, velocityY / 3);
                    }
                    break;
                case 3:
                    if (rb.velocity.x > 0)
                    {
                        rb.velocity = new Vector2(velocityX / 3, velocityY);
                    }
                    break;
                    break;
                default:
                    break;
            }

            jumpCount = -1;
        }

        return jumpCount;
    }
}
