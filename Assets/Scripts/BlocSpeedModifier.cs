using UnityEngine;
using System.Collections;

public class BlocSpeedModifier : MonoBehaviour {

    public float reduceSpeed = 0.6f;
    public float accelerationTime;
    public int lowSpeedTime = 5;
    private float stockBaseSpeed;
    private float stockMaxSpeed;
    PlayerMovement playerMovementScript; 

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Player")
        {
            playerMovementScript = col.gameObject.transform.parent.GetComponent<PlayerMovement>();
            stockBaseSpeed = playerMovementScript.baseSpeed;
            playerMovementScript.baseSpeed = playerMovementScript.baseSpeed * reduceSpeed;
            Debug.Log(playerMovementScript.baseSpeed * reduceSpeed);
            stockMaxSpeed = playerMovementScript.MaxSpeed;
            playerMovementScript.MaxSpeed = playerMovementScript.MaxSpeed * reduceSpeed;
            StartCoroutine(reducingSpeed());
            //StartCoroutine(destructionBloc());
        }
    }

    IEnumerator reducingSpeed()
    {
        Debug.Log("hello");
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
                Debug.Log(playerMovementScript.MaxSpeed);
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

    //IEnumerator destructionBloc()
    //{
    //    int _tmp = 0;
    //    while (_tmp < 20)
    //    {
    //        _tmp++;
    //        yield return new WaitForEndOfFrame();
    //    }
    //    Destroy(gameObject);
    //    yield return null;

    //}

}
