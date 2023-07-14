using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSignal : MonoBehaviour
{
    public bool positiveSignal = false;
    public bool negativeSignal = false;
    public bool isConnected = false;
    //public AudioSource connectFX;
    public GameObject selfWire;

    

    void OnTriggerStay(Collider collider)
    {
        
        if(collider.gameObject.tag == "PositiveSignal" || collider.gameObject.tag == "PositiveWire")
        {
            //connectFX.Play();
            gameObject.tag = "PositiveWire";
            isConnected = true;
            positiveSignal = true;
        }
        else if(collider.gameObject.tag == "NegativeSignal" || collider.gameObject.tag == "NegativeWire")
        {
            gameObject.tag = "NegativeWire";
            isConnected = true;
            negativeSignal = true;
        }
        
    }

    void OnTriggerExit(Collider collider)
    {
        gameObject.tag = "Untagged";
        isConnected = false;
        positiveSignal = false;
        negativeSignal = false;
    }
    
}


