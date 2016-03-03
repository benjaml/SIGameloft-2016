using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollectible : MonoBehaviour {

    public List<GameObject> listCollectible = new List<GameObject>();
    public GameObject collectibleTarget;
    //private GameObject lastObject = this;

    void Start ()
    {
        listCollectible.Add(collectibleTarget);
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "collectible")
        {
            col.transform.position = new Vector3();
            col.GetComponent<CollectibleMovement>().collected = true;
        }
    }
}
