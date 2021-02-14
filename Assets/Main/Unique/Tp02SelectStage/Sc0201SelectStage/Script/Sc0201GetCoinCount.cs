using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc0201GetCoinCount : MonoBehaviour
{
    // 全コイン数取得
    TotalCoinsCount totalCoinsCount = new TotalCoinsCount();

    SaveLoadGetCoinsCount getCoinCount = new SaveLoadGetCoinsCount();

    // 初期化
    void Start()
    {
        int total = totalCoinsCount.sumCoinsCount();
        int[] getCoins = getCoinCount.loadAll();
    }
}
