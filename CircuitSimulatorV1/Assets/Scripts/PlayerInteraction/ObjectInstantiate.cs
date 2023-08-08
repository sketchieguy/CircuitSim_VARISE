using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToinstantiate;
    public void InstantiateObject()
    {
        Instantiate(objectToinstantiate, Vector3.zero, Quaternion.identity);
    }
}
