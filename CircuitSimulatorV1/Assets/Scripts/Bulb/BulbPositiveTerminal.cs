using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbPositiveTerminal : MonoBehaviour
{
    public BulbGlow bulb;
    public bool activePositive = false;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "PositiveWire")
        {
            activePositive = true;
            bulb.checkPositiveSignal = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        activePositive = false;
        bulb.checkPositiveSignal = false;
        bulb.isGlow = false;
    }

}
