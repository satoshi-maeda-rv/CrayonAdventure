using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc0201GetCoinCount : MonoBehaviour
{
    // 全コイン数取得
    TotalCoinsCount totalCoinsCount = new TotalCoinsCount();

    SaveLoadGetCoinsCount getCoinCount = new SaveLoadGetCoinsCount();

    public GameObject progress;

    // 初期化
    void Start()
    {
        int total = totalCoinsCount.sumCoinsCount();
        int[] getCoins = getCoinCount.loadAll();

        int sum = 0;
        foreach (int getCoin in getCoins)
        {
            sum += getCoin;
        }

        // floatで進行度を計算
        float floatProgressCoins = (float) sum / (float) total * 100f;

        int progressCoins = (int) floatProgressCoins;

        Text progressText = progress.GetComponent<Text>();

        progressText.text = "進行度：" + progressCoins + "%";
    }
}
