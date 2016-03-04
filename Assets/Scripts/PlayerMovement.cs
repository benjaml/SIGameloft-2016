﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float cylinderRadius = 2.5f;
    public float distanceFromCenter = 5f;
    private float heightModificator;
    public float speed = 6.0F;
    public float turnSpeed = 3.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

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
    

    void Start()
    {
    }


    void Update()
    {
        //heightModificator -= CONDITION ? SI OUI: SI NON;
        heightModificator -= Input.GetKey(KeyCode.E) ? 0.03f : 0.0f;
        heightModificator += Input.GetKey(KeyCode.Z) ? 0.03f : 0.0f;
        heightModificator = Mathf.Clamp(heightModificator, -1.5f, 2.0f);
        heightModificator *= 0.95f;
        distanceFromCenter = 5.0f + heightModificator;


        isGrounded = distanceFromCenter <10.0f ? true : false;

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
        if (Physics.Raycast(transform.position+transform.forward, -transform.up, out hit))
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
                lookRotation = Quaternion.FromToRotation(transform.forward, (secondGravityCenter - gravityCenter).normalized);
            }
        }
        // on applique les transformation de rotation a la rotation actuelle
        //targetRotation *= transform.rotation;
        //float tmpGrav = gravity;
        gravityDirection = gravityCenter - transform.position;
        //gravityDirection.Normalize();
        if (isGrounded)
        {
            //tmpGrav *= 0.1f;
            // avance sur le tube avec la variabe speed
            moveDirection = Input.GetAxisRaw("Vertical")*transform.forward*speed;
            // tourne autour du tube avec la variabe turnSpeed
            moveDirection += Input.GetAxisRaw("Horizontal")*transform.right*turnSpeed;
            if (Input.GetButton("Jump"))
                moveDirection += jumpSpeed*-gravityDirection;

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
        transform.position = Vector3.Lerp(transform.position,gravityCenter + (targetPosition - gravityCenter).normalized*distanceFromCenter,0.1f);
        // on applique les modification de position et rotation en smooth
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);
        transform.rotation = Quaternion.Slerp(transform.rotation,transform.rotation*Quaternion.FromToRotation(transform.forward, (secondGravityCenter - gravityCenter).normalized), 0.01f);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation*transform.rotation, 0.1f);



        Debug.DrawLine(transform.position, transform.position + (secondGravityCenter - gravityCenter).normalized*10.0f,Color.red);





        /*if (transform.position.y > gravityCenter.y)
        {
            Debug.Log("YES");
        }
        else
        {
            Debug.Log("NO");
            Quaternion tmpRot = Quaternion.FromToRotation(transform.forward, transform.forward - (secondGravityCenter - gravityCenter).normalized);
            tmpRot.x *= -1;
            transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation * tmpRot, 0.01f);
            
        }*/

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