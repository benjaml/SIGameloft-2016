using UnityEngine;
using System.Collections;

public class AreaSpeedModifier : MonoBehaviour {

    public float modifierSpeedMax = 2;
    public bool decelerate = false;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            PlayerController _controller = col.gameObject.GetComponent<PlayerController>();

            if (decelerate)
            {
                _controller.divideSpeedMax(modifierSpeedMax);
            }
            else
            {
                _controller.multiplySpeedMax(modifierSpeedMax);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerController _controller = col.gameObject.GetComponent<PlayerController>();

            if (decelerate)
            {
                _controller.multiplySpeedMax(modifierSpeedMax);
            }
            else
            {
                _controller.divideSpeedMax(modifierSpeedMax);
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
