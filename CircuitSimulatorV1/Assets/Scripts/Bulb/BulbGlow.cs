using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbGlow : MonoBehaviour
{
    public bool checkPositiveSignal = false;
    public bool checkNegativeSignal = false;
    public bool isGlow = false;
    //public LightGlow lightUp;

    //public BulbPositiveTerminal bPosTerm;
    //public BulbNegativeTerminal bNegTerm;

    public AudioSource connectFX;

    void Start()
    {
        
    }

    void Update()
    {
        if (checkPositiveSignal == true && checkNegativeSignal == true)
        {
            isGlow = true;
            
            connectFX.Play();

        }

    }
}
