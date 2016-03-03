using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollectible : MonoBehaviour {

    public List<GameObject> listCollectible = new List<GameObject>();
    public GameObject targetCollectible;
    public GameObject lastObject;

    private float randomWidth; //x
    private float randomHeight; //y
    private float randomDistance; //z

    void Start ()
    {

        listCollectible.Add(targetCollectible);
    }

    void OnTriggerEnter (Collider col)
    {


        if (col.tag == "collectible")
        {
            if (!listCollectible.Contains(col.gameObject))
            {
                listCollectible.Add(col.gameObject);
                lastObject = listCollectible[listCollectible.Count - 2];
            }

            randomWidth = Random.Range(-0.25f, 0.25f);
            randomHeight = Random.Range(-1, 0.5f);
            randomDistance = Random.Range(-0.15f, 0.5f);

            
            col.transform.eulerAngles = lastObject.transform.eulerAngles;
            col.transform.position = new Vector3((targetCollectible.transform.position.x + randomWidth), 
                                                  targetCollectible.transform.position.y + randomHeight, 
                                                  lastObject.transform.position.z + randomDistance + 0.1f);

            col.GetComponent<CollectibleMovement>().offsetInitialisation();

            col.GetComponent<CollectibleMovement>().collected = true;
            col.transform.gameObject.tag = "collected";

        }
    }
}
