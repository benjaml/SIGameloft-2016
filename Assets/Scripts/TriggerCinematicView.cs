using UnityEngine;
using UnityStandardAssets.Utility;
using System.Collections;
public class TriggerCinematicView : MonoBehaviour
{
    public bool isFresco = true;
    public bool isGameCam = false;
    public bool winning = false;
    public float frescoBaseSpeed = 5.0f;
    public SkyController02 sky;
    private int countDaytime = 1;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (isFresco)
            {
                Camera.main.GetComponent<SmoothFollow>().fresqueMode();
                col.transform.parent.GetComponent<PlayerMovement>().frescoMode(frescoBaseSpeed);
                GameManagerWrath.instance.freezeWrath();
                sky.startDayCycle(countDaytime);
                countDaytime++;
            }
            if (isGameCam)
            {
                Camera.main.GetComponent<SmoothFollow>().gameMode();
                col.transform.parent.GetComponent<PlayerMovement>().gameMode();
                GameManagerWrath.instance.resetWrath();
                GameManagerWrath.instance.continueWrath();
            }

            if(winning)
            {
                GameManager.instance.win();
            }
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}