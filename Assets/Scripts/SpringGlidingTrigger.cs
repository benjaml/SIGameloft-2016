using UnityEngine;
using System.Collections;

public class SpringGlidingTrigger : MonoBehaviour {

    public float heightJump = 15.0f;
    public float speedJump = 20.0f;
    public float speedFall = 1.0f;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            col.transform.parent.GetComponent<PlayerMovement>().Spring(speedJump, heightJump, speedFall);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
