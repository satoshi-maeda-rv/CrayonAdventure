using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBottomCollider : MonoBehaviour
{
    GameObject ridePlayerMover;

    RidePlayerMove script;

    void Start()
    {
        ridePlayerMover = GameObject.Find("RidePlayerMover");
        script = ridePlayerMover.GetComponent<RidePlayerMove>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bottomCollider")
        {
            Debug.Log(col.transform.parent.gameObject.name);
            script.objName = col.transform.parent.gameObject.name;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "bottomCollider")
        {
            script.objName = "none";
        }
    }
}
