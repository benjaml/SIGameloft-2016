using UnityEngine;
using System.Collections;

public class BlocSpeedModifier : MonoBehaviour {

    public float modifierSpeed = 2;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerController>().reduceCurrentSpeed(modifierSpeed);
            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
