﻿using UnityEngine;
using System.Collections;

public class CollectibleMovement : MonoBehaviour
{
    public Transform target;            // The position that that camera will be following.
    public float smoothing = 1f;        // The speed with which the camera will be following.

    Vector3 offsetPos;                     // The initial offset from the target.
    //Vector3 offsetRot;

    void Start()
    {
        // Calculate the initial offset.
        offsetPos = transform.position - target.position;

    }

    void FixedUpdate()
    {
        // Create a postion the camera is aiming for based on the offset from the target.
        Vector3 targetCamPos = new Vector3(target.position.x, target.position.y, target.position.z) + offsetPos;

        // Smoothly interpolate between the camera's current position and it's target position.
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

         

        //Keep the same rotation than the target
        transform.eulerAngles = target.eulerAngles;
    }
}