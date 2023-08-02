using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanNegativeTerminal : MonoBehaviour
{
    public FanSpin fan;
    public bool activeNegative = false;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "NegativeWire")
        {
            activeNegative = true;
            fan.checkNegativeSignal = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        activeNegative = false;
        fan.checkNegativeSignal = false;
        fan.isSpin = false;
    }
}
