﻿using UnityEngine;
using System.Collections;
using ParticlePlayground;

public class CollectibleMovement : MonoBehaviour
{
    public Transform targetCollectible;
    public Transform previousTarget;            // The position that that camera will be following.
    private float smoothing = 30;               // The speed with which the camera will be following.
    public bool collected;
    public GameObject player;

    private Vector3 offsetPos;                  // The initial offset from the previousTarget.



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform.parent.gameObject;
        targetCollectible = player.GetComponent<PlayerCollectible>().targetCollectible.transform;

    }

    public void offsetInitialisation ()
    {
        GameObject tmp = player.GetComponent<PlayerCollectible>().lastObject;
        previousTarget = player.GetComponent<PlayerCollectible>().lastObject.transform;
        offsetPos = (transform.position - previousTarget.position);
    }

    void Update()
    {
        if (collected == true)
        {
            // Create a postion the collectible is aiming for based on the offset from the previousTarget.
            if (previousTarget != null)
            {
                Vector3 _targetPos = new Vector3(targetCollectible.position.x, previousTarget.position.y, previousTarget.position.z) + (offsetPos / 3);

                // Smoothly interpolate between the camera's current position and it's previousTarget position.
                transform.position = Vector3.Lerp(transform.position, _targetPos, smoothing * Time.deltaTime);



                //Keep the same rotation than the previousTarget
                transform.eulerAngles = previousTarget.eulerAngles;
            }
        }
    }

}
