using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc0101ChangeScene : MonoBehaviour
{
    // 処理中
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Sc0201SelectStageScene");
        }
    }
}
