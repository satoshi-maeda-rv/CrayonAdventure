using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
class SaveLoadGetCoinsCount
{
    public static SaveLoadGetCoinsCount GetInstance()
    {
        return new SaveLoadGetCoinsCount();
    }

    public void saveStage1(int coinsCount)
    {
        PlayerPrefs.SetInt("stage1", coinsCount);
    }

    public void saveStage2(int coinsCount)
    {
        PlayerPrefs.SetInt("stage2", coinsCount);
    }

    public void saveStage3(int coinsCount)
    {
        PlayerPrefs.SetInt("stage3", coinsCount);
    }

    public void saveStage4(int coinsCount)
    {
        PlayerPrefs.SetInt("stage4", coinsCount);
    }

    public void saveStage5(int coinsCount)
    {
        PlayerPrefs.SetInt("stage5", coinsCount);
    }

    public void saveStage6(int coinsCount)
    {
        PlayerPrefs.SetInt("stage6", coinsCount);
    }

    public void saveStage7(int coinsCount)
    {
        PlayerPrefs.SetInt("stage7", coinsCount);
    }

    public void saveStage8(int coinsCount)
    {
        PlayerPrefs.SetInt("stage8", coinsCount);
    }

    public int loadStage1()
    {
        return PlayerPrefs.GetInt("stage1", 0);
    }

    public int loadStage2()
    {
        return PlayerPrefs.GetInt("stage2", 0);
    }

    public int loadStage3()
    {
        return PlayerPrefs.GetInt("stage3", 0);
    }

    public int loadStage4()
    {
        return PlayerPrefs.GetInt("stage4", 0);
    }

    public int loadStage5()
    {
        return PlayerPrefs.GetInt("stage5", 0);
    }

    public int loadStage6()
    {
        return PlayerPrefs.GetInt("stage6", 0);
    }

    public int loadStage7()
    {
        return PlayerPrefs.GetInt("stage7", 0);
    }

    public int loadStage8()
    {
        return PlayerPrefs.GetInt("stage8", 0);
    }

    public int[] loadAll()
    {
        int[] allData = new int[8];

        for (int i = 0; i < 8; i++)
        {
            string key = string.Format("stage{0}", i + 1);
            allData[i] = PlayerPrefs.GetInt(key, 0);
        }

        return allData;
    }
}
