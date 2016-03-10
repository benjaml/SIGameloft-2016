﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlocSpeedModifier : MonoBehaviour {

    private float reduceSpeed = 1f;
    private float accelerationTime = 5f;
    private float lowSpeedTime = 2f;
    public float percentOfFlowerLost = 30;

    private float flowersLost;
    private float stockBaseSpeed;
    private float stockMaxSpeed;

    private List<GameObject> flowersList;
    PlayerMovement playerMovementScript; 

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Player")
        {
            flowersList = col.gameObject.transform.parent.GetComponent<PlayerCollectible>().listCollectible;
            losingFlowers();

            playerMovementScript = col.gameObject.transform.parent.GetComponent<PlayerMovement>();

            stockBaseSpeed = playerMovementScript.baseSpeed;
            stockMaxSpeed = playerMovementScript.MaxSpeed;

            playerMovementScript.baseSpeed = playerMovementScript.baseSpeed * reduceSpeed;


            playerMovementScript.MaxSpeed = playerMovementScript.MaxSpeed * reduceSpeed;


            StartCoroutine(reducingSpeed());
            
            //Add a certain value to the dragon wrath
        }
    }

    IEnumerator reducingSpeed()
    {
        float _tmp = 0f;
        while (_tmp < lowSpeedTime)
        {
            _tmp +=0.1f;
            yield return new WaitForSeconds(0.1f);
        }
        while (playerMovementScript.MaxSpeed < stockMaxSpeed)
        {
            playerMovementScript.baseSpeed += accelerationTime;
            playerMovementScript.MaxSpeed += accelerationTime;
            yield return new WaitForSeconds(0.2f);
        }
        playerMovementScript.baseSpeed= stockBaseSpeed;
        playerMovementScript.MaxSpeed = stockMaxSpeed;
        yield return null;
    }

    void losingFlowers()
    {

        flowersLost = (flowersList.Count - 1) - (Mathf.Floor((flowersList.Count - 1) * (1 - (percentOfFlowerLost / 100))));
        for (int i = 0; i < flowersLost; i++)
        {
            if (flowersList[flowersList.Count - 1] != flowersList[0])
            {
                GameObject tmp = flowersList[flowersList.Count - 1];
                flowersList.Remove(flowersList[flowersList.Count - 1]);
                Destroy(tmp);
            }

        }


    }

}
