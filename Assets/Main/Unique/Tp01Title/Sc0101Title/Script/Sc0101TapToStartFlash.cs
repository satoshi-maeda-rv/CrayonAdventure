using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc0101TapToStartFlash : MonoBehaviour
{
    private float nextTime;

    public float interval = 1.0f; // 点滅周期

    private Renderer renderer;

    void Start()
    {
        nextTime = Time.time;
        renderer = this.GetComponent<Renderer>();
    }

    void Update()
    {
        if (Time.time > nextTime)
        {
            renderer.enabled = !renderer.enabled;

            nextTime += interval;
        }
    }
}
