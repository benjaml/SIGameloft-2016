using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BlocSpeedModifier : MonoBehaviour
{
    private float reduceSpeed = 2.0f;
    public float accelerationTime;
    private int lowSpeedTime = 2;
    private int flowersLost = 5;
    private float stockBaseSpeed;
    private float stockMaxSpeed;
    private List<GameObject> flowersList;
    PlayerMovement playerMovementScript;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            flowersList = col.gameObject.transform.parent.GetComponent<PlayerCollectible>().listCollectible;
            losingFlowers();
            playerMovementScript = col.gameObject.transform.parent.GetComponent<PlayerMovement>();
            playerMovementScript.reduceCurrentSpeed(reduceSpeed, lowSpeedTime);

            //Add a certain value to the dragon wrath
        }
    }
    void losingFlowers()
    {
        Debug.Log(flowersLost);
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