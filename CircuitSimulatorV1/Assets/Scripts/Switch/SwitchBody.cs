using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBody : MonoBehaviour
{
    public bool switchOn = false;


    void OnTriggerStay(Collider collider)
    {

        if (collider.gameObject.tag == "Plug")
        {
            switchOn = true;
            Debug.Log("switch on");
        }
    }
    void OnTriggerExit(Collider collider)
    {
        //gameObject.tag = "Untagged";
        switchOn = false;
    }
}
