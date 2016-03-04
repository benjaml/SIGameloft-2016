using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {


    public Transform target;
    public Vector3 offset;

    public float smoothTime;
    Vector3 smoothVel;

    Vector3 smoothMove;

    // Use this for initialization
    void Start ()
    {

        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //smoothMove = Vector3.SmoothDamp(transform.position, target.position + offset, ref smoothVel, smoothTime);
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref smoothVel, smoothTime);
        transform.LookAt(target.position, Vector3.up);
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(target.position + offset, 0.5f);
    }
}
