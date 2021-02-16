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

        int progressCoins = sum / total * 100;

        Text progressText = progress.GetComponent<Text>();

        progressText.text = "進行度：" + progressCoins + "%";
    }
}
