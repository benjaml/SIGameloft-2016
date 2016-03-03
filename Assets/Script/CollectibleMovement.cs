using UnityEngine;
using System.Collections;

public class CollectibleMovement : MonoBehaviour
{
    public Transform target;            // The position that that camera will be following.
    public float smoothing = 5f;        // The speed with which the camera will be following.

    Vector3 offsetPos;                     // The initial offset from the target.
    //Vector3 offsetRot;

    void Start()
    {
        // Calculate the initial offset.
        offsetPos = transform.position - target.position;
        //offsetRot = transform.eulerAngles - target.eulerAngles;
    }

    void FixedUpdate()
    {
        // Create a postion the camera is aiming for based on the offset from the target.
        Vector3 targetCamPos = target.position + offsetPos;

        // Smoothly interpolate between the camera's current position and it's target position.
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

        transform.eulerAngles = target.eulerAngles;
    }
}
