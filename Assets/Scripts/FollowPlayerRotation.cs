using UnityEngine;
using System.Collections;

public class FollowPlayerRotation : MonoBehaviour {

    public Transform Player;

    private Vector3 _rot;

	// Use this for initialization
	void Start () {
        _rot = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {

        //transform.eulerAngles = new Vector3(Player.eulerAngles.z - 90, _rot.y, _rot.z);
        //transform.eulerAngles = new Vector3(_rot.x, Player.eulerAngles.z, _rot.z);
        //transform.eulerAngles = new Vector3(_rot.x, _rot.y, Player.eulerAngles.z);

    }
}
