using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc0305GoalFlag : MonoBehaviour
{
    // コイン取得数
    public int coinsCount;

    // ワイド
    private string nameWide = "wide";

    // トール
    private string nameTall = "tall";

    // 始めに当たったキャラの名前
    public string firstGoalCharaName = "none";

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.transform.parent.gameObject.name);
        if (collider.transform.parent.gameObject.tag == "player")
        {
            if (collider.transform.parent.gameObject.name == nameWide)
            {
                if (firstGoalCharaName == nameTall)
                {
                    Debug.Log (coinsCount);
                    SaveLoadGetCoinsCount.GetInstance().saveStage5(coinsCount);
                    SceneManager.LoadScene("Sc0201SelectStageScene");
                }
                else
                {
                    firstGoalCharaName = nameWide;
                    Destroy(collider.transform.parent.gameObject);
                }
            }
            else if (collider.transform.parent.gameObject.name == nameTall)
            {
                if (firstGoalCharaName == nameWide)
                {
                    Debug.Log (coinsCount);
                    SaveLoadGetCoinsCount.GetInstance().saveStage5(coinsCount);
                    SceneManager.LoadScene("Sc0201SelectStageScene");
                }
                else
                {
                    firstGoalCharaName = nameTall;
                    Destroy(collider.transform.parent.gameObject);
                }
            }
        }
    }
}
