using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private float SpeedX = 0;//Don't touch this
    private float SpeedZ = 0;
    public float MaxSpeed = 10;//This is the maximum speed that the object will achieve
    public float Acceleration = 10;//How fast will object reach a maximum speed
    public float Deceleration = 10;//How fast will object reach a speed of 0

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    

    void Update()
    {
        if ((Input.GetKey("right")) && (SpeedX < MaxSpeed))
            SpeedX = SpeedX + Acceleration * Time.deltaTime;
        else if ((Input.GetKey("left")) && (SpeedX > -MaxSpeed))
            SpeedX = SpeedX - Acceleration * Time.deltaTime;
        else
        {
            if (SpeedX > Deceleration * Time.deltaTime)
                SpeedX = SpeedX - Deceleration * Time.deltaTime;
            else if (SpeedX < -Deceleration * Time.deltaTime)
                SpeedX = SpeedX + Deceleration * Time.deltaTime;
            else
                SpeedX = 0;
        }

        if ((Input.GetKey("up")) && (SpeedZ < MaxSpeed))
            SpeedZ = SpeedZ + Acceleration * Time.deltaTime;
        else if ((Input.GetKey("down")) && (SpeedZ > -MaxSpeed))
            SpeedZ = SpeedZ - Acceleration * Time.deltaTime;
        else
        {
            if (SpeedZ > Deceleration * Time.deltaTime)
                SpeedZ = SpeedZ - Deceleration * Time.deltaTime;
            else if (SpeedZ < -Deceleration * Time.deltaTime)
                SpeedZ = SpeedZ + Deceleration * Time.deltaTime;
            else
                SpeedZ = 0;
        }

        Debug.Log(rb.velocity);

        Vector3 _movement = Vector3.zero;

        _movement.x = transform.position.x + SpeedX * Time.deltaTime;
        _movement.z = transform.position.z + SpeedZ * Time.deltaTime;
        _movement.y = transform.position.y;

        rb.MovePosition(_movement);
        rb.velocity = Vector3.zero;
    }

    public void multiplySpeed(float _modifier)
    {
        MaxSpeed *= _modifier;
    }

    public void divideSpeed(float _modifier)
    {
        MaxSpeed /= _modifier;
    }
}
