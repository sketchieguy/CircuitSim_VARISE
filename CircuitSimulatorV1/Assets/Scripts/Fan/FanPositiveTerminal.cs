using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanPositiveTerminal : MonoBehaviour
{
    public FanSpin fan;
    public bool activePositive = false;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "PositiveWire")
        {
            activePositive = true;
            fan.checkPositiveSignal = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        activePositive = false;
        fan.checkPositiveSignal = false;
        fan.isSpin = false;
    }
}
