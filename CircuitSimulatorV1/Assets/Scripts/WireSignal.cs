using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSignal : MonoBehaviour
{
   // public bool positiveSignal = false;
   // public bool negativeSignal = false;
    public bool isConnected = false;
    public AudioSource connectFX;
    public GameObject selfWire;

    void OnCollisionEnter(Collision collision)
    {
        connectFX.Play();
        isConnected = true;
        GameObject other = collision.gameObject;
        if (other.GetComponent<SignalState>().positiveSignal == true)
        {
            connectFX.Play();
            selfWire.GetComponent<SignalState>().positiveSignal = true;
            Debug.Log("test");
            //Debug.Log(positiveSignal);
        }
        /*else if (Collision.gameObject.GetComponent<TestSifnal.negativeSignal>() == true)
        {
            negativeSignal = true;
        }*/
    }

   /* void OnTriggerExit(Collider other)
    {
        isConnected=false;
        positiveSignal=false;
        negativeSignal=false;
    }*/

    
}
