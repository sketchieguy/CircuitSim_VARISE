using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGlow : MonoBehaviour
{
    public Light bulbLight;
    public BulbGlow bulbGlow;
    // Start is called before the first frame update
    void Start()
    {
        bulbLight = GetComponent<Light>();
        bulbLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(bulbGlow.isGlow == true)
        {
            bulbLight.enabled = true;
        }
        else 
        { 
            bulbLight.enabled = false;
        }
    }
}
