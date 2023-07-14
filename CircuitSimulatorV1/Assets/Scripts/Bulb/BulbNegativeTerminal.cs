using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbNegativeTerminal : MonoBehaviour
{
    public BulbGlow bulb;
    public bool activeNegative = false;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "NegativeWire")
        {
            activeNegative = true;
            bulb.checkNegativeSignal = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        activeNegative = false;
    }
}
