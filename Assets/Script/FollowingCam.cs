using UnityEngine;
using System.Collections;

public class FollowingCam : MonoBehaviour {

    [SerializeField]
    private Transform player;
    [SerializeField]
    private float rotationDamping;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        var wantedRotationAngle = player.eulerAngles.z;
        var currentRotationAngle = transform.eulerAngles.z;

        Debug.DrawLine(player.position, player.position + player.up * 100);
        Debug.DrawLine(transform.position, transform.position + transform.up * 100, Color.red);
        Debug.Log("pl " + player.up);
        Debug.Log("cam " + transform.up);

        transform.rotation *= Quaternion.FromToRotation(transform.up, player.up);

        //transform.Rotate(new Vector3(0, 0, 10));
	}
}
