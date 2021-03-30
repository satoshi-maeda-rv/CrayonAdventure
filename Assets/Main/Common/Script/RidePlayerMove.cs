using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidePlayerMove : MonoBehaviour
{
    GameObject wide;

    Rigidbody2D rbWide;

    GameObject tall;

    Rigidbody2D rbTall;

    MovePrayer wideScript;

    MovePrayer tallScript;

    public float jumpAddSpeed;

    public string objName;

    Jump jumpClass = new Jump();

    void Start()
    {
        wide = GameObject.Find("wide");
        rbWide = wide.GetComponent<Rigidbody2D>();
        wideScript = wide.GetComponent<MovePrayer>();
        tall = GameObject.Find("tall");
        rbTall = tall.GetComponent<Rigidbody2D>();
        tallScript = tall.GetComponent<MovePrayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objName == "wide" && !wideScript.Player)
        {
            rbWide.velocity = new Vector2(rbTall.velocity.x, rbWide.velocity.y);

            // int jumpCount = jumpClass.tapJumpButton(rbWide, 5, jumpAddSpeed, 5);
        }
        else if (objName == "tall" && !tallScript.Player)
        {
            rbTall.velocity = new Vector2(rbWide.velocity.x, rbTall.velocity.y);

            // int jumpCount = jumpClass.tapJumpButton(rbTall, 5, jumpAddSpeed, 5);
        }
    }
}
