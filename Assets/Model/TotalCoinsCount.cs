using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
class TotalCoinsCount
{
    public void saveTotalCoinsCount()
    {
        TotalStageCoinsCount coinsCount = new TotalStageCoinsCount();

        coinsCount.stage1 = 3;
        coinsCount.stage2 = 3;
        coinsCount.stage3 = 4;
        coinsCount.stage4 = 4;
        coinsCount.stage5 = 3;
        coinsCount.stage6 = 3;
        coinsCount.stage7 = 5;
        coinsCount.stage8 = 4;

        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(coinsCount);

        writer =
            new StreamWriter(Application.dataPath + "/Model/coinsCount.json",
                false);
        writer.Write (jsonstr);
        writer.Flush();
        writer.Close();
    }

    public TotalStageCoinsCount loadTotalCoinsCount()
    {
        string datastr = "";
        StreamReader reader;
        reader =
            new StreamReader(Application.dataPath + "/Model/coinsCount.json");
        datastr = reader.ReadToEnd();
        reader.Close();

        return JsonUtility.FromJson<TotalStageCoinsCount>(datastr);
    }

    public int sumCoinsCount()
    {
        TotalStageCoinsCount loadCount = loadTotalCoinsCount();

        int counter = 0;

        counter = counter + loadCount.stage1;
        counter = counter + loadCount.stage2;
        counter = counter + loadCount.stage3;
        counter = counter + loadCount.stage4;
        counter = counter + loadCount.stage5;
        counter = counter + loadCount.stage6;
        counter = counter + loadCount.stage7;
        counter = counter + loadCount.stage8;

        return counter;
    }
}

/// ステージごとのコインの数
[System.Serializable]
public class TotalStageCoinsCount
{
    public int stage1;

    public int stage2;

    public int stage3;

    public int stage4;

    public int stage5;

    public int stage6;

    public int stage7;

    public int stage8;
}
