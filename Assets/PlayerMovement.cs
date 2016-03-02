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

    public Spiral currentSpiral;
    public float currentMinY = 0.0f;
    public float currentMaxY = 0.0f;

    public Vector3 gravityCenter;
    private Vector3 targetPosition;
    private Vector3 forwardDirection;
    private Quaternion targetRotation;
    private Vector3 lookDirection;
    public Vector3 gravityDirection;
    private Rigidbody rb;
    private bool onSpiral = false;
    private Vector3 moveDirection = Vector3.zero;
    public bool isGrounded = false;
    public float curDir = 0.0f;
    public float mouseSensibility = 20f;
    float rotationY = 0f;
    private float minimumY = -45f;
    private float maximumY = 45f;

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
            if (hit.transform.tag == "spiral")
            {
                onSpiral = true;
            }
            else
            {
                onSpiral = false;
            }
            if (hit.transform.tag == "floor")
            {
                gravityCenter = hit.point - hit.normal*hit.transform.localScale.z* cylinderRadius;
                targetRotation = Quaternion.FromToRotation(transform.up, (transform.position-gravityCenter).normalized );
            }

        }
        //RaycastHit hit2;

        //update the player forward direction with the spiral
        if (Physics.Raycast(transform.position+transform.forward*0.1f, - transform.up, out hit))
        {
            Debug.DrawLine(transform.position + transform.forward,
                transform.position + transform.forward - transform.up,Color.blue);

            if (hit.transform.tag == "floor")
            {
                Vector3 secondGravityCenter = hit.point - hit.normal * hit.transform.localScale.z*cylinderRadius;
                Debug.DrawLine(hit.point, hit.normal, Color.green);

                Debug.DrawLine(gravityCenter, gravityCenter + Vector3.up * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter - Vector3.up * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter + Vector3.right * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter - Vector3.right * 5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter + Vector3.up*5,Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter - Vector3.up*5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter + Vector3.right*5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter - Vector3.right*5,Color.red);
                lookDirection = (secondGravityCenter - gravityCenter).normalized;
                Debug.DrawLine(transform.position, lookDirection, Color.red);

            }
        }
        targetRotation *= transform.rotation;
        float tmpGrav = gravity;
        gravityDirection = gravityCenter - transform.position;
        gravityDirection.Normalize();
        if (isGrounded)
        {
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

    Vector3 circleCenter(Vector3 A, Vector3 B, Vector3 C)
    {

        float yDelta_a = B.y - A.y;
        float xDelta_a = B.x - A.x;
        float yDelta_b = C.y - B.y;
        float xDelta_b = C.x - B.x;
        Vector3 center = Vector3.zero;

        float aSlope = yDelta_a / xDelta_a;
        float bSlope = yDelta_b / xDelta_b;
        center.x = (aSlope * bSlope * (A.y - C.y) + bSlope * (A.x + B.x)
            - aSlope * (B.x + C.x)) / (2 * (bSlope - aSlope));
        center.y = -1 * (center.x - (A.x + B.x) / 2) / aSlope + (A.y + B.y) / 2;

        return center;
    }

    void ApplyMovement()
    {
        rb.MovePosition(Vector3.Lerp(transform.position, targetPosition, 0.5f));
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
