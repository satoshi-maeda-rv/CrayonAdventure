using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RotateChara
{
    // 角度許容値
    private float diffTlerance = 1f;

    // 角度差分
    private float diff = 0.0f;

    // シングルトン
    public static RotateChara GetInstance()
    {
        return new RotateChara();
    }

    public void moveChara(
        GameObject obj,
        Rigidbody2D rb,
        // 重力方向
        // 0下、1右、2上、3左
        int gravityDirection
    )
    {
        switch (gravityDirection)
        {
            case 0:
                // 下方向重力の時
                // 現状の回転角との差を取得
                diff = Mathf.Abs(obj.transform.localEulerAngles.z);

                if (diff >= diffTlerance)
                {
                    // どう回転するにしても左回転
                    obj.transform.rotation *=
                        Quaternion.AngleAxis(1, new Vector3(0.0f, 0.0f, 5.0f));

                    rb.velocity = new Vector2(0.0f, 0.0f);
                }
                else
                // 回転終了時
                {
                    // 重力を下方向に変更
                    // 重力を一度のみ変更する
                    if (Physics2D.gravity != new Vector2(0.0f, -9.8f))
                    {
                        Physics2D.gravity = new Vector2(0.0f, -9.8f);
                    }
                }
                break;
            case 1:
                // 右方向重力の時
                // 現状の回転角との差を取得
                diff = Mathf.Abs(obj.transform.localEulerAngles.z - 90);

                if (diff >= diffTlerance)
                {
                    // どう回転するにしても左回転
                    obj.transform.rotation *=
                        Quaternion.AngleAxis(1, new Vector3(0.0f, 0.0f, 5.0f));

                    rb.velocity = new Vector2(0.0f, 0.0f);
                }
                else
                // 回転終了時
                {
                    // 重力を右方向に変更
                    // 重力を一度のみ変更する
                    if (Physics2D.gravity != new Vector2(9.8f, 0.0f))
                    {
                        Physics2D.gravity = new Vector2(9.8f, 0.0f);
                    }
                }
                break;
            case 2:
                // 上方向重力の時
                // 現状の回転角との差を取得
                diff = Mathf.Abs(obj.transform.localEulerAngles.z - 180);
                if (diff >= diffTlerance)
                {
                    // どう回転するにしても左回転
                    obj.transform.rotation *=
                        Quaternion.AngleAxis(1, new Vector3(0.0f, 0.0f, 5.0f));

                    rb.velocity = new Vector2(0.0f, 0.0f);
                }
                else
                // 回転終了時
                {
                    // 重力を上方向に変更
                    // 重力を一度のみ変更する
                    if (Physics2D.gravity != new Vector2(0.0f, 9.8f))
                    {
                        Physics2D.gravity = new Vector2(0.0f, 9.8f);
                    }
                }
                break;
            case 3:
                // 左方向重力の時
                // 現状の回転角との差を取得
                diff = Mathf.Abs(obj.transform.localEulerAngles.z - 270);

                if (diff >= diffTlerance)
                {
                    // どう回転するにしても左回転
                    obj.transform.rotation *=
                        Quaternion.AngleAxis(1, new Vector3(0.0f, 0.0f, 5.0f));

                    rb.velocity = new Vector2(0.0f, 0.0f);
                }
                else
                // 回転終了時
                {
                    // 重力を左方向に変更
                    // 重力を一度のみ変更する
                    if (Physics2D.gravity != new Vector2(-9.8f, 0.0f))
                    {
                        Physics2D.gravity = new Vector2(-9.8f, 0.0f);
                    }
                }
                break;
            default:
                break;
        }
    }
}
