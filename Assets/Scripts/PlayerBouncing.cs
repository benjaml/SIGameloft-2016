using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PlayerBouncing : MonoBehaviour {

    private float baseSpeedAir;

    Vector3 objectPosition; //The position object that will reflect the player
    Vector3 direction; //Direction in which the character will be reflected

    GameObject objectCollision;
    PlayerMovement playerMovementScript;

    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovement>();
        baseSpeedAir = playerMovementScript.baseAirSpeed;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "obstacleFloor")
        {
            float _stockBaseSpeed = playerMovementScript.baseSpeed;

            Debug.Log(transform.position);

            objectCollision = col.gameObject;
            objectPosition = new Vector3(objectCollision.transform.position.x, objectCollision.transform.position.y, objectCollision.transform.position.z);
            direction = objectPosition - transform.position;
            Debug.Log(transform.position);


            playerMovementScript.baseSpeed = playerMovementScript.baseSpeed/2;
            //Movement arrière dotween
            transform.DOMoveZ(transform.position.z + (direction.z * -1), 0.5f);
            transform.DOMoveX(transform.position.x + (direction.x * -1), 0.5f);
            playerMovementScript.baseSpeed = _stockBaseSpeed;
            return;
        }
        if (col.tag == "obstcaleAir")
        {
            Debug.Log("hello");
            float _stockBaseAirSpeed = playerMovementScript.baseAirSpeed;

            Debug.Log(transform.position);

            objectCollision = col.gameObject;
            objectPosition = new Vector3(objectCollision.transform.position.x, objectCollision.transform.position.y, objectCollision.transform.position.z);
            direction = objectPosition - transform.position;
            Debug.Log(transform.position);


            playerMovementScript.baseAirSpeed = playerMovementScript.baseAirSpeed/2;
            //Movement arrière dotween
            transform.DOMoveZ(transform.position.z + (direction.z * -1), 0.5f);
            transform.DOMoveX(transform.position.x + (direction.x * -1), 0.5f);
            playerMovementScript.baseAirSpeed = _stockBaseAirSpeed;
            return;
        }
    }
}
