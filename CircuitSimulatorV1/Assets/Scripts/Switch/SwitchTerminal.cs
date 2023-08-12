using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTerminal : MonoBehaviour
{
    public SwitchBody switchBody;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<WireSignal>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        if(switchBody.switchOn == true)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            //gameObject.GetComponent<WireSignal>().enabled = true;
        }
        /*else
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }*/
    }
}
