using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireMovement : MonoBehaviour
{
    /*public Vector3 targetPosition;
    public Collider targetCollider;
    public Collider myCollider;
    public float snapDistance = 1;
    void Update()
    {
        transform.position = targetPosition;
        Vector3 myClosestPoint = myCollider.ClosestPoint(targetCollider.transform.position);
        Vector3 targetClosestPoint = targetCollider.ClosestPoint(myClosestPoint);
        Vector3 offset = targetClosestPoint - myClosestPoint;
        if (offset.magnitude < snapDistance)
        {
            transform.position += offset;
        }
    }*/
    Vector3 mousePosition;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
    bool snapped = false;
    GameObject snapparent; 
    Vector3 offset;

    void Update()
    {
        if (snapped == true)
        {

            transform.position = snapparent.transform.position + offset;
        }
    }
    void OnTriggerStay(Collider collider)
    {

        if (collider.gameObject.tag == "PositiveSignal" || collider.gameObject.tag == "PositiveWire" || collider.gameObject.tag == "NegativeSignal" || collider.gameObject.tag == "NegativeWire")
        {
            snapped = true;
            snapparent = collider.gameObject;
            offset = transform.position - snapparent.transform.position;
        }
        

    }
}
