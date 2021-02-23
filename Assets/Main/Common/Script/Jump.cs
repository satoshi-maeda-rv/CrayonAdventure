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
        int jumpCount,
        float jumpAddSpeed,
        int canJumpCount
    )
    {
        // 取り直す
        float velocityX = rb.velocity.x;

        // ジャンプ処理
        if (Input.GetKey(KeyCode.X))
        {
            if (jumpCount == canJumpCount)
            {
                rb.velocity = new Vector2(velocityX, jumpAddSpeed);
                return canJumpCount + 2;
            }
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            if (rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(velocityX, 0);
            }

            jumpCount = -1;
        }

        return jumpCount;
    }
}
