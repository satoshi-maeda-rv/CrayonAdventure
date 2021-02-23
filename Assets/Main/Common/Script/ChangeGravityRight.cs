using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravityRight : MonoBehaviour
{
    GameObject wide;

    GameObject tall;

    void Start()
    {
        wide = GameObject.Find("wide");
        tall = GameObject.Find("tall");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Physics2D.gravity = new Vector2(9.8f, 0.0f);

        wide.transform.Rotate(0, 0, 90f);
        tall.transform.Rotate(0, 0, 90f);
        Destroy (gameObject);
    }
}
