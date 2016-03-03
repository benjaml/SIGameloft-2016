using UnityEngine;
using System.Collections;

public class PlayerDetector : MonoBehaviour
{

    public float cylinderRadius = 2.5f;
    public float distanceFromCenter = 5f;

    //Player Movement reference
    public PlayerMovement pm;
    public LayerMask layer;

    

    // Use this for initialization
    void Start ()
	{
	    //pm = transform.parent.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        
    RaycastHit hit;
        /* je fait un raycast vers le bas du joueur pour rentrer en collision avec la spirale
         * Une fois que j'ai le point de collision avec la spirale, je récupère la normal au point de collision
         * Pour avoir le centre de la spirale, je prend le point de collision ou je retire la normal * le radius du tube*/
        if (Physics.Raycast(transform.position, -transform.up, out hit, layer))
        {
            Debug.DrawLine(transform.position, transform.position-transform.up * 10.0f, Color.red);
            if (hit.transform.tag == "floor")
            {
                Debug.Log("YEAY");
                return;
            }
            Debug.Log("I found something");

        }
        else
        {
            Debug.Log("I can't see s**t");
            return;
        }
        
    }
}
