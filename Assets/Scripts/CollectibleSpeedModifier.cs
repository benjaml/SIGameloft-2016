using UnityEngine;
using System.Collections;

public class CollectibleSpeedModifier : MonoBehaviour {

    public float modifierSpeed = 2;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.gameObject.transform.parent.GetComponent<PlayerMovement>().multiplyCurrentSpeed(modifierSpeed);
            Destroy(this);
        }
    }
}
