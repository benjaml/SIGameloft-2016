﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlocSpeedModifier : MonoBehaviour
{

    public float reduceSpeed = 2.0f;
    public float accelerationTime;
    public float lowSpeedTime = 5f;
    public float percentOfFlowerLost = 30;

    private float flowersLost;
    private float stockBaseSpeed;
    private float stockMaxSpeed;

    private List<GameObject> flowersList;
    PlayerMovement playerMovementScript;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            SoundManagerEvent.emit(SoundManagerType.Impact);
            SoundManagerEvent.emit(SoundManagerType.CharacterHurt);
            flowersList = col.gameObject.transform.parent.GetComponent<PlayerCollectible>().listCollectible;
            losingFlowers();

            playerMovementScript = col.gameObject.transform.parent.GetComponent<PlayerMovement>();
            playerMovementScript.reduceCurrentSpeed(reduceSpeed, lowSpeedTime);


            //Add a certain value to the dragon wrath
        }
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
