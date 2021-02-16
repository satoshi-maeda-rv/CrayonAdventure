using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc0201TapStage : MonoBehaviour
{
    GameObject clickedGameObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d =
                Physics2D
                    .Raycast((Vector2) ray.origin, (Vector2) ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
                SceneManager.LoadScene(clickedGameObject.name);
            }
        }
    }
}
