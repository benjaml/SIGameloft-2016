﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    private float cylinderRadius = 5f;
    public float baseDistanceFromCenter = 7.0f;
    public float distanceFromCenter = 5f;
    private float groundDetection = 7.2f;
    private float heightModificator;
    public float turnSpeedMax = 3.0F;
    public float airTurnSpeedMax = 3.0f;
    public float jumpSpeed = 50.0F;
    public float accelerationJump = 5.0f;
    public float heightJump = 5.0f;
    private bool jumping = false;
    private bool jumped = false;
    public float speedFall = 0.50f;
    public float gravity = 20.0F;
    public float baseSpeed = 50.0f;
    public float baseAirSpeed = 25.0f;
    public float slowSpeed = 10.0f;
    public float slowAirSpeed = 5.0f;

    private float turnSpeed = 0;//Don't touch this
    private float speedForward = 0;
    public float MaxSpeed = 10;//This is the maximum speed that the object will achieve
    public float MaxAirSpeed = 10.0f;
    public float turnAcceleration = 10.0f;
    public float turnDeceleration = 10.0f;
    public float Acceleration = 10;//How fast will object reach a maximum speed
    public float Deceleration = 10;//How fast will object reach a speed of 0
    public float airAcceleration = 10;
    public float airDeceleration = 10;
    public float turnAirAcceleration = 10.0f;
    public float turnAirDeceleration = 10.0f;
    public float speedDash = 300.0f;
    public float dashCooldown = 5.0f;
    public float dashDuration = 1.0f;
    private float startHeightmax;
    public float heightMaxDuration = 0.0f;
    private float timeStartDash;
    private bool dashing = false;
    private bool rightDash = false;
    private bool leftDash = false;
    private bool lDashed = false;
    private bool rDashed = false;
    private float _xStick = 0.0f;
    private float initJumpSpeed, initHeightJump, initSpeedFall, accelerateJump;

    //position et rotation que je personnage devrais avoir en fin de déplacement
    private Vector3 targetPosition;
    private Quaternion targetRotation;
    private Quaternion lookRotation;
    //position du centre de gravité
    public Vector3 gravityCenter;
    public Vector3 secondGravityCenter;
    // direction de la force de gravité
    public Vector3 gravityDirection;
    // vector3 utilisé pour le déplacement
    private Vector3 moveDirection = Vector3.zero;
    // est ce que le joueur est au sol ( surtout utilisé pour pouvoir sauter)
    public bool isGrounded = false;


    public Animator animator;
    public bool isFresco = false;

    void Start()
    {
        timeStartDash = -dashCooldown;
        initHeightJump = heightJump;
        initJumpSpeed = jumpSpeed;
        initSpeedFall = speedFall;
        accelerateJump = 0.0f;
        distanceFromCenter = baseDistanceFromCenter;
        groundDetection = baseDistanceFromCenter + 0.2f;
    }


    void Update()
    {
        //Fait Marcher les tremplins. pourquoi? parce que voilà.
        //Debug.Log("jS " + jumpSpeed);
        //Debug.Log("sF " + speedFall);
        //Debug.Log("hJ " + heightJump);

        //heightModificator -= CONDITION ? SI OUI: SI NON;
        if (!isFresco)
        {

            if (isGrounded)
            {
                if (Input.GetAxisRaw("R_YAxis_0") > 0.3 || Input.GetButton("B_0") || Input.GetKey(KeyCode.Z))
                {
                    heightModificator -= 0.3f;
                }
                else
                {
                    heightModificator -= 0.0f;
                }

                if (!jumping)
                {
                    accelerateJump = accelerationJump;
                    jumpSpeed = initJumpSpeed;
                    speedFall = initSpeedFall;
                    heightJump = initHeightJump;
                }
            }

            if ((Input.GetAxisRaw("R_YAxis_0") < -0.3 || Input.GetButtonDown("A_0") || Input.GetKeyDown(KeyCode.Space)) &&
                isGrounded && !jumped)
            {
                Invoke("launchJumping", 0.75f);

                animator.SetTrigger("jump");
            }
        }

        if(jumped && (Input.GetAxisRaw("R_YAxis_0") > -0.3 || Input.GetButtonUp("A_0") || Input.GetKeyUp(KeyCode.Space)))
        {
            jumped = false;
        }

        if ((Input.GetAxisRaw("TriggersL_0") > 0.3 || Input.GetKeyDown(KeyCode.E)) && (timeStartDash + dashCooldown < Time.time) && isGrounded && !lDashed)
        {
            timeStartDash = Time.time;
            dashing = true;
            leftDash = true;
            animator.SetTrigger("barellRollLeft");
            lDashed = true;
        }

        if (Input.GetAxisRaw("TriggersL_0") < 0.3)
            lDashed = false;

        if ((Input.GetAxisRaw("TriggersR_0") > 0.3 || Input.GetKeyDown(KeyCode.R)) && (timeStartDash + dashCooldown < Time.time) && isGrounded && !rDashed)
        {
            timeStartDash = Time.time;
            dashing = true;
            rightDash = true;
            animator.SetTrigger("barellRollRight");
            rDashed = true;
        }

        if (Input.GetAxisRaw("TriggersR_0") < 0.3)
            rDashed = false;

        if (jumping)
        {
            if (accelerateJump > 0.1f)
                accelerateJump -= Time.deltaTime * 1.5f;
            else
                accelerateJump = 0.1f;

            heightModificator += jumpSpeed * accelerateJump * Time.deltaTime;
        }

        heightModificator = Mathf.Clamp(heightModificator, -2.5f, heightJump);

        if (heightModificator >= heightJump)
        {
            if (jumping)
                startHeightmax = Time.time;
            jumping = false;
            accelerateJump = 0.0f;
        }

        if (!jumping && !isGrounded && (startHeightmax + heightMaxDuration < Time.time))
        {
            accelerateJump += Time.deltaTime;
            heightModificator -= speedFall * accelerateJump * Time.deltaTime;
        }
        else if (!jumping && !jumped && (startHeightmax + heightMaxDuration < Time.time))
            heightModificator *= 0.98f;

        distanceFromCenter = baseDistanceFromCenter + heightModificator;
        isGrounded = distanceFromCenter < groundDetection ? true : false;

        /*if (Mathf.Abs(Input.GetAxisRaw("Vertical")) < 0.3f && Mathf.Abs(Input.GetAxisRaw("Horizontal")) < 0.3f)
            return;*/

        // update gravity center
        RaycastHit hit;
        /* je fait un raycast vers le bas du joueur pour rentrer en collision avec la spirale
         * Une fois que j'ai le point de collision avec la spirale, je récupère la normal au point de collision
         * Pour avoir le centre de la spirale, je prend le point de collision ou je retire la normal * le radius du tube*/
        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            //Debug.DrawLine(transform.position, transform.position+transform.up * 10, Color.red);
            if (hit.transform.tag == "floor")
            {
                //Debug.DrawLine(hit.point, hit.point+hit.normal*10, Color.green);
                gravityCenter = hit.point - hit.normal*hit.transform.localScale.z*cylinderRadius;
                // petite méthode magique pour faire des rotation propre tu met la direction que tu veux changer et celle que tu veux et il la met bien
                // le soucis de transform.up = (transform.position-gravityCenter).normalized, c'est qu'il te donne la bonne orientation mais tu as pas la bonne transform.rotation
                // tu peux te retrouver a regarder dans une toute autre direction
                // A-->B    positionB-positionA ( !! penser a normaliser )
                targetRotation = Quaternion.FromToRotation(transform.up, (transform.position - gravityCenter).normalized);
            }

        }
        else
        {
            Debug.Log("I can't see s**t");
        }

        //update the player forward direction with the spiral
        // je refait un autre raycast mais devant le personnage pour récupérer le point de gravité un peu devant le personnage
        // pour réorienter le personnage, je prend le vecteur entre les 2 points de gravité pour l'appliquer au joueur
        if (Physics.Raycast(transform.position+transform.forward*2.0f, -transform.up, out hit))
        {
            
            //Debug.DrawLine(transform.position + transform.forward,transform.position + transform.forward - transform.up*10.0f,Color.blue);
            if (hit.transform.tag == "floor")
            {
                secondGravityCenter = hit.point - (hit.normal *cylinderRadius);
                
                // permet de voir les points de gravité
                Debug.DrawLine(hit.point, hit.normal, Color.green);
                DebugPoint(gravityCenter, Color.red);
                DebugPoint(secondGravityCenter, Color.red);
                // Idem que au dessus, avec le (*=) pour combiner les 2 quaternions
                targetRotation *= Quaternion.FromToRotation(transform.forward, (secondGravityCenter - gravityCenter).normalized);
            }
        }
        // on applique les transformation de rotation a la rotation actuelle
        //targetRotation *= transform.rotation;
        //float tmpGrav = gravity;
        gravityDirection = gravityCenter - transform.position;
        //gravityDirection.Normalize();

        if(isGrounded)
        {
            //tmpGrav *= 0.1f;
            // avance sur le tube avec la variabe speed
            moveDirection = transform.forward * calculateSpeedForward();
            // tourne autour du tube avec la variabe turnSpeed
            if(!isFresco)
                moveDirection += transform.right * calculateTurnSpeed();
        }
        else
        {
            //tmpGrav *= 0.1f;
            // avance sur le tube avec la variabe speed
            moveDirection = transform.forward * calculateAirSpeedForward();
            // tourne autour du tube avec la variabe turnSpeed
            if (!isFresco)
                moveDirection += transform.right * calculateAirTurnSpeed();
        }
        
        // on ajoute la gravité au déplacement
        //moveDirection += tmpGrav*Time.deltaTime*gravityDirection;
        targetPosition = (transform.position + (moveDirection*Time.deltaTime));
        ApplyMovement();
    }
    
    void ApplyMovement()
    {
        DebugPoint(targetPosition, Color.blue);
        DebugPoint(gravityCenter + (targetPosition - gravityCenter).normalized*distanceFromCenter, Color.black);
        //Debug.DrawLine(gravityCenter, gravityCenter + (targetPosition - gravityCenter).normalized*distanceFromCenter,Color.yellow);
        transform.position = Vector3.Lerp(transform.position,gravityCenter + (targetPosition - gravityCenter).normalized*distanceFromCenter,0.5f);
        // on applique les modification de position et rotation en smooth
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation*transform.rotation, 0.1f);
    }


    public void launchJumping()
    {
        jumped = true;
        jumping = true;
    }

    //calculate the turn speed when grounded
    float calculateTurnSpeed()
    {
        if(!dashing)
            _xStick = Input.GetAxisRaw("Horizontal");
        else
        {
            if (leftDash)
                _xStick = -1.0f;

            if (rightDash)
                _xStick = 1.0f;
        }

        if (((_xStick > 0.3) || (_xStick < -0.3)) && (turnSpeed < turnSpeedMax) && (turnSpeed > -turnSpeedMax))
        {

            if ((_xStick > 0.3) && turnSpeed < 0)
                turnSpeed = 0;

            if ((_xStick < -0.3) && turnSpeed > 0)
                turnSpeed = 0;


            if((timeStartDash + dashDuration > Time.time))
            {
                turnSpeed = turnSpeed + _xStick * turnAcceleration * speedDash * Time.deltaTime;
            }
            else
            {
                turnSpeed = turnSpeed + _xStick * turnAcceleration * Time.deltaTime;
                dashing = false;
                rightDash = false;
                leftDash = false;
            }
        }
        else
        {
            if (turnSpeed > turnSpeedMax)
                turnSpeed = turnSpeedMax;
            else if (turnSpeed < -turnSpeedMax)
                turnSpeed = -turnSpeedMax;
            else if (turnSpeed > turnDeceleration * Time.deltaTime)
                turnSpeed = turnSpeed - turnDeceleration * Time.deltaTime;
            else if (turnSpeed < -turnDeceleration * Time.deltaTime)
                turnSpeed = turnSpeed + turnDeceleration * Time.deltaTime;
            else
                turnSpeed = 0;
        }

        return turnSpeed;
    }

    //calculate the turn speed when in air
    float calculateAirTurnSpeed()
    {
        float _xStick = Input.GetAxisRaw("Horizontal");

        if (((_xStick > 0.3) || (_xStick < -0.3)) && (turnSpeed < airTurnSpeedMax) && (turnSpeed > -airTurnSpeedMax))
        {

            turnSpeed = turnSpeed + _xStick * turnAirAcceleration * Time.deltaTime;
        }
        else
        {
            if (turnSpeed > turnAirDeceleration * Time.deltaTime)
                turnSpeed = turnSpeed - turnAirDeceleration * Time.deltaTime;
            else if (turnSpeed < -turnAirDeceleration * Time.deltaTime)
                turnSpeed = turnSpeed + turnAirDeceleration * Time.deltaTime;
            else
                turnSpeed = 0;
        }

        return turnSpeed;
    }

    //calculate speed forward when grounded
    float calculateSpeedForward()
    {
        float _yStick = Input.GetAxisRaw("Vertical");

        if (((_yStick > 0.3) || (_yStick < -0.3)) && (speedForward < MaxSpeed) && (speedForward >= slowSpeed))
            speedForward += _yStick * Acceleration * Time.deltaTime;
        else
        {
            if (speedForward > baseSpeed + Deceleration * Time.deltaTime)
                speedForward = speedForward - Deceleration * Time.deltaTime;
            else if (speedForward < -baseSpeed  + Deceleration * Time.deltaTime)
                speedForward = speedForward + Deceleration * Time.deltaTime;
            else
                speedForward = baseSpeed;
        }

        return speedForward;
    }

    //calculate speed forward when in air
    float calculateAirSpeedForward()
    {
        float _yStick = Input.GetAxisRaw("Vertical");

        if (((_yStick > 0.3) || (_yStick < -0.3)) && (speedForward < MaxAirSpeed) && (speedForward >= slowAirSpeed))
            speedForward += _yStick * airAcceleration * Time.deltaTime;
        else
        {
            if (speedForward > baseAirSpeed + airDeceleration * Time.deltaTime)
                speedForward = speedForward - airDeceleration * Time.deltaTime;
            else if (speedForward < -baseAirSpeed + airDeceleration * Time.deltaTime)
                speedForward = speedForward + airDeceleration * Time.deltaTime;
            else
                speedForward = baseAirSpeed;
        }

        return speedForward;
    }

    public void reduceCurrentSpeed(float _modifier)
    {
        turnSpeed /= _modifier;
        speedForward /= _modifier;
    }

    public void multiplyCurrentSpeed(float _modifier)
    {
        turnSpeed *= _modifier;
        speedForward *= _modifier;
    }
    

    public void multiplySpeedMax(float _modifier)
    {
        MaxSpeed *= _modifier;
        turnSpeedMax *= _modifier;
    }

    public void divideSpeedMax(float _modifier)
    {
        MaxSpeed /= _modifier;
        turnSpeedMax /= _modifier;
    }

    public void Spring(float _jumpSpeedMod, float _heightJumpMod, float _speedFallMod)
    {
        jumping = true;
        heightJump = _heightJumpMod;
        jumpSpeed = _jumpSpeedMod;
        speedFall = _speedFallMod;
    }

    public float getBaseSpeed()
    {
        if (isGrounded)
            return baseSpeed;
        return baseAirSpeed;
    }

    public float getMaxSpeed()
    {
        if (isGrounded)
            return MaxSpeed;
        return MaxAirSpeed;
    }

    public float getSpeed()
    {
        return speedForward;
    }

    void DebugPoint(Vector3 position, Color color)
    {
        Debug.DrawLine(position, position + Vector3.up * 5, color);
        Debug.DrawLine(position, position - Vector3.up * 5, color);
        Debug.DrawLine(position, position + Vector3.right * 5, color);
        Debug.DrawLine(position, position - Vector3.right * 5, color);
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
