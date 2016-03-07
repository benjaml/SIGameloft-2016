using UnityEngine;
using System.Collections;

public class AnimateBell : MonoBehaviour {

    public float speedBellAnimation = 5.0f;
    public float maxRotationBell = 30.0f;
    private float rotationBell;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        rotationBell = Mathf.Cos(Time.time) * maxRotationBell;

        transform.Rotate(transform.right, rotationBell * speedBellAnimation * Time.deltaTime);
	}
}
