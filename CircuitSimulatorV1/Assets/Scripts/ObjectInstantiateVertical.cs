using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiateVertical : MonoBehaviour
{
    public GameObject objectToinstantiate;
    public void InstantiateObject()
    {
        Instantiate(objectToinstantiate, Vector3.zero, Quaternion.identity);
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.y += 90.0f;
        transform.eulerAngles = currentRotation;

    }
}
