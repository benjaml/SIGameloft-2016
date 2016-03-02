using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    public float cylinderRadius = 2.5f;
    public float speed = 6.0F;
    public float turnSpeed = 3.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    

    public Vector3 gravityCenter;
    private Vector3 targetPosition;
    private Vector3 forwardDirection;
    private Quaternion targetRotation;
    private Vector3 lookDirection;
    public Vector3 gravityDirection;
    private Rigidbody rb;
    private Vector3 moveDirection = Vector3.zero;
    public bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        // update gravity center
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            Debug.DrawLine(transform.position, transform.position+transform.up * 10, Color.red);
            if (hit.transform.tag == "floor")
            {
                Debug.DrawLine(hit.point, hit.point+hit.normal*10, Color.green);
                gravityCenter = hit.point - hit.normal*hit.transform.localScale.z* cylinderRadius;
                targetRotation = Quaternion.FromToRotation(transform.up, (transform.position-gravityCenter).normalized );
            }

        }
        //RaycastHit hit2;

        //update the player forward direction with the spiral
        if (Physics.Raycast(transform.position+transform.forward, -transform.up, out hit))
        {
            Debug.DrawLine(transform.position + transform.forward,transform.position + transform.forward - transform.up*10.0f,Color.blue);

            if (hit.transform.tag == "floor")
            {
                Vector3 secondGravityCenter = hit.point - (hit.normal *cylinderRadius);
                Debug.DrawLine(hit.point, hit.normal, Color.green);

                Debug.DrawLine(gravityCenter, gravityCenter + Vector3.up * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter - Vector3.up * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter + Vector3.right * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter - Vector3.right * 5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter + Vector3.up*5,Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter - Vector3.up*5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter + Vector3.right*5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter - Vector3.right*5,Color.red);
                targetRotation *= Quaternion.FromToRotation(transform.forward, (secondGravityCenter - gravityCenter).normalized);
                Debug.DrawLine(transform.position, lookDirection, Color.red);
            }
        }
        targetRotation *= transform.rotation;
        float tmpGrav = gravity;
        gravityDirection = gravityCenter - transform.position;
        gravityDirection.Normalize();
        if (isGrounded)
        {
            tmpGrav *= 0.1f;
            // avance sur le tube
            moveDirection = Input.GetAxisRaw("Vertical")*transform.forward*speed;
            // tourne autour du tube
            moveDirection += Input.GetAxisRaw("Horizontal")*transform.right*turnSpeed;
            if (Input.GetButton("Jump"))
                moveDirection += jumpSpeed*-gravityDirection;

        }
        moveDirection += tmpGrav*Time.deltaTime*gravityDirection;
        targetPosition = (transform.position + (moveDirection*Time.deltaTime));
        ApplyMovement();
    }
    
    void ApplyMovement()
    {
        rb.MovePosition(Vector3.Lerp(transform.position, targetPosition, 0.3f));
        rb.MoveRotation( Quaternion.Slerp(transform.rotation, targetRotation, 0.1f));
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "floor")
            isGrounded = true;
    }

    void OnCollisionExit(Collision col)
    {
        if (col.transform.tag == "floor")
            isGrounded = false;
    }
}
