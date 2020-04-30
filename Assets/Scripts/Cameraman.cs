using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraman : MonoBehaviour
{
    private bool isMoving = true;
    private bool isTriggered;
    private Quaternion newRotation = Quaternion.Euler(0f, -180f, 0f);
    
    [SerializeField] private Transform targetLocation;
    [SerializeField] private Transform theDoor;
    
    void Update()
    {
        if (isMoving == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetLocation.position, 1 * Time.deltaTime);
        }

        if (isTriggered)
        {
            theDoor.transform.rotation = Quaternion.RotateTowards(theDoor.transform.rotation, newRotation , 90f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
    }
}
