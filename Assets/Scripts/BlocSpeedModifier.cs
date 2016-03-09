using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlocSpeedModifier : MonoBehaviour {

    public float reduceSpeed = 0.6f;
    public float accelerationTime;
    public int lowSpeedTime = 5;
    public int flowersLost = 5;

    private float stockBaseSpeed;
    private float stockMaxSpeed;

    private List<GameObject> flowersList;
    PlayerMovement playerMovementScript; 

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Player")
        {
            SoundManagerEvent.emit(SoundManagerType.Damage);
            flowersList = col.gameObject.transform.parent.GetComponent<PlayerCollectible>().listCollectible;
            losingFlowers();

            playerMovementScript = col.gameObject.transform.parent.GetComponent<PlayerMovement>();

            stockBaseSpeed = playerMovementScript.baseSpeed;
            playerMovementScript.baseSpeed = playerMovementScript.baseSpeed * reduceSpeed;


            stockMaxSpeed = playerMovementScript.MaxSpeed;
            playerMovementScript.MaxSpeed = playerMovementScript.MaxSpeed * reduceSpeed;


            StartCoroutine(reducingSpeed());
            
            //Add a certain value to the dragon wrath
        }
    }

    IEnumerator reducingSpeed()
    {
        int _tmp = 0;
        while (_tmp < lowSpeedTime)
        {
            _tmp++;
            yield return new WaitForSeconds(0.1f);
        }
        if (_tmp >= lowSpeedTime)
        {
            while (playerMovementScript.MaxSpeed < stockMaxSpeed)
            {

                playerMovementScript.baseSpeed += accelerationTime;
                playerMovementScript.MaxSpeed += accelerationTime;
                yield return new WaitForSeconds(0.2f);
            }
        }
        Debug.Log(stockMaxSpeed);
        playerMovementScript.baseSpeed= stockBaseSpeed;
        playerMovementScript.MaxSpeed = stockMaxSpeed;
        yield return null;
    }

    void losingFlowers()
    {
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
