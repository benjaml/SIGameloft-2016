using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 5.0f;
    private Rigidbody rb;
    private Vector3 velocity;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 _horizontalMov = transform.right * Input.GetAxisRaw("Horizontal");
        Vector3 _verticalMov = transform.forward * Input.GetAxisRaw("Vertical");

        velocity = _horizontalMov + _verticalMov;
        velocity = velocity.normalized;
        velocity *= speed;
    }

    void FixedUpdate()
    {
        if(velocity != Vector3.zero)
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
