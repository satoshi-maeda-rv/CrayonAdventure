using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc0101SaveJson : MonoBehaviour
{
    TotalCoinsCount totalCoinsCount = new TotalCoinsCount();

    // Start is called before the first frame update
    void Start()
    {
        totalCoinsCount.saveTotalCoinsCount();
        TotalStageCoinsCount coinsCount = totalCoinsCount.loadTotalCoinsCount();

        Debug.Log(coinsCount.stage1);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
