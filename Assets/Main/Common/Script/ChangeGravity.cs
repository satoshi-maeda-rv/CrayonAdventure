using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Physics2D.gravity = new Vector2(0.0f, 9.8f);
    }
}
