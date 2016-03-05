using UnityEngine;
using System.Collections;

public class BlocSpeedModifier : MonoBehaviour {

    public float modifierSpeed = 20;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.transform.parent.GetComponent<PlayerMovement>().reduceCurrentSpeed(modifierSpeed);
            //Destroy(gameObject);

        }
    }

}
