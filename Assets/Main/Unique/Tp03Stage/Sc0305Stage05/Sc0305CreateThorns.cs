using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc0305CreateThorns : MonoBehaviour
{
    // トゲオブジェクト
    public GameObject thornsDown;
    // トゲ生成待ち時間
    float span = 1.0f;
    // トゲ待ち時間差分
    float delta = 0.0f;

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span) {
            delta = 0;
            GameObject thorns1 = Instantiate(thornsDown) as GameObject;
            int randX1 = Random.Range(-36, 36);
            thorns1.transform.position = new Vector3(randX1 / 3, 8, 0);

            GameObject thorns2 = Instantiate(thornsDown) as GameObject;
            int randX2 = Random.Range(-36, 36);
            thorns2.transform.position = new Vector3(randX2 / 3, 8, 0);
        }
    }
}
