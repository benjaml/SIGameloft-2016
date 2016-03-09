using UnityEngine;
using UnityStandardAssets.Utility;
using System.Collections;

public class TriggerCinematicView : MonoBehaviour {

    public bool isFresco = true;
    public bool isGameCam = false;
    public float frescoBaseSpeed = 5.0f;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if (isFresco)
            {
                Camera.main.GetComponent<SmoothFollow>().fresqueMode();
                col.transform.parent.GetComponent<PlayerMovement>().frescoMode(frescoBaseSpeed);
            }

            if (isGameCam)
            {
                Camera.main.GetComponent<SmoothFollow>().gameMode();
                col.transform.parent.GetComponent<PlayerMovement>().gameMode();
            }
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
