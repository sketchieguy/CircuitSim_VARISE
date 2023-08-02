using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanSpin : MonoBehaviour
{
    public bool checkPositiveSignal = false;
    public bool checkNegativeSignal = false;
    public bool isSpin = false;
    

    public AudioSource connectFX;

    void Start()
    {

    }

    void Update()
    {
        if (checkPositiveSignal == true && checkNegativeSignal == true)
        {
            isSpin = true;
            transform.Rotate(0, 0, 5, Space.World);

            connectFX.Play();

        }

    }
}
