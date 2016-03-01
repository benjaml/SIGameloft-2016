using UnityEngine;
using System.Collections;

public class VitesseModifier : MonoBehaviour {

    public float modifierSpeedMax = 2;
    public bool decelerate = false;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Enter : " + decelerate);
            PlayerController _controller = col.gameObject.GetComponent<PlayerController>();

            if (decelerate)
            {
                _controller.divideSpeed(modifierSpeedMax);
            }
            else
            {
                _controller.multiplySpeed(modifierSpeedMax);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Exit : " + decelerate);
            PlayerController _controller = col.gameObject.GetComponent<PlayerController>();

            if (decelerate)
            {
                _controller.multiplySpeed(modifierSpeedMax);
            }
            else
            {
                _controller.divideSpeed(modifierSpeedMax);
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
