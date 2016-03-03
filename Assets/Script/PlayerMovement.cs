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

    //position et rotation que je personnage devrais avoir en fin de déplacement
    private Vector3 targetPosition;
    private Quaternion targetRotation;
    //position du centre de gravité
    public Vector3 gravityCenter;
    // direction de la force de gravité
    public Vector3 gravityDirection;
    // vector3 utilisé pour le déplacement
    private Vector3 moveDirection = Vector3.zero;
    // est ce que le joueur est au sol ( surtout utilisé pour pouvoir sauter)
    public bool isGrounded = false;
    // réference sur le rigidbody
    private Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
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
                gravityCenter = hit.point - hit.normal*hit.transform.localScale.z* cylinderRadius;
                // petite méthode magique pour faire des rotation propre tu met la direction que tu veux changer et celle que tu veux et il la met bien
                // le soucis de transform.up = (transform.position-gravityCenter).normalized, c'est qu'il te donne la bonne orientation mais tu as pas la bonne transform.rotation
                // tu peux te retrouver a regarder dans une toute autre direction
                targetRotation = Quaternion.FromToRotation(transform.up, (transform.position-gravityCenter).normalized );
            }

        }

        //update the player forward direction with the spiral
        // je refait un autre raycast mais devant le personnage pour récupérer le point de gravité un peu devant le personnage
        // pour réorienter le personnage, je prend le vecteur entre les 2 points de gravité pour l'appliquer au joueur
        if (Physics.Raycast(transform.position+transform.forward, -transform.up, out hit))
        {
            
            //Debug.DrawLine(transform.position + transform.forward,transform.position + transform.forward - transform.up*10.0f,Color.blue);

            if (hit.transform.tag == "floor")
            {
                Vector3 secondGravityCenter = hit.point - (hit.normal *cylinderRadius);
                
                // permet de voir les points de gravité
                /*Debug.DrawLine(hit.point, hit.normal, Color.green);
                Debug.DrawLine(gravityCenter, gravityCenter + Vector3.up * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter - Vector3.up * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter + Vector3.right * 5, Color.red);
                Debug.DrawLine(gravityCenter, gravityCenter - Vector3.right * 5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter + Vector3.up*5,Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter - Vector3.up*5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter + Vector3.right*5, Color.red);
                Debug.DrawLine(secondGravityCenter, secondGravityCenter - Vector3.right*5,Color.red);*/
                // Idem que au dessus, avec le (*=) pour combiner les 2 quaternions
                targetRotation *= Quaternion.FromToRotation(transform.forward, (secondGravityCenter - gravityCenter).normalized);
            }
        }
        // on applique les transformation de rotation a la rotation actuelle
        targetRotation *= transform.rotation;
        float tmpGrav = gravity;
        gravityDirection = gravityCenter - transform.position;
        gravityDirection.Normalize();
        if (isGrounded)
        {
            tmpGrav *= 0.1f;
            // avance sur le tube avec la variabe speed
            moveDirection = Input.GetAxisRaw("Vertical")*transform.forward*speed;
            // tourne autour du tube avec la variabe turnSpeed
            moveDirection += Input.GetAxisRaw("Horizontal")*transform.right*turnSpeed;
            if (Input.GetButton("Jump"))
                moveDirection += jumpSpeed*-gravityDirection;

        }
        // on ajoute la gravité au déplacement
        moveDirection += tmpGrav*Time.deltaTime*gravityDirection;
        targetPosition = (transform.position + (moveDirection*Time.deltaTime));
        ApplyMovement();
    }
    
    void ApplyMovement()
    {
        // on applique les modification de position et rotation en smooth
        rb.MovePosition(Vector3.Lerp(transform.position, targetPosition, 0.3f));
        rb.MoveRotation( Quaternion.Slerp(transform.rotation, targetRotation, 0.3f));
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
