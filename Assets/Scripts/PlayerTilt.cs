 using UnityEngine;
using System.Collections;

public class PlayerTilt : MonoBehaviour {

    public float tilt;

    void Start () {
	
	}

	void Update () {
        transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, transform.localEulerAngles.y, (Input.GetAxis("Horizontal") * -tilt));
        
    }
}
