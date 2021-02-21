using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jump : MonoBehaviour
{

    public int tapJumpButton(Rigidbody2D rb, int jumpCount, float jumpAddSpeed)
    {
        // 取り直す
        float velocityX = rb.velocity.x;
        // ジャンプ処理
        if (Input.GetKey(KeyCode.X))
        {
            if (jumpCount == 2)
            {
                rb.velocity = new Vector2(velocityX, jumpAddSpeed);
                return -1;
            }
        }

        return jumpCount;

    }
}
