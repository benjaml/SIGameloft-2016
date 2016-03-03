using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollectible : MonoBehaviour {

    public List<GameObject> listCollectible = new List<GameObject>();
    public GameObject targetCollectible;
    public GameObject _lastObject;


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
                _lastObject = listCollectible[listCollectible.Count - 2];
            }
            Debug.Log("touched collectible");
            col.transform.eulerAngles = _lastObject.transform.eulerAngles;
            col.transform.position = new Vector3(_lastObject.transform.position.x, _lastObject.transform.position.y - 0.2f, _lastObject.transform.position.z + 1);
            col.GetComponent<CollectibleMovement>().offsetInitialisation();
            col.GetComponent<CollectibleMovement>().collected = true;
            col.transform.gameObject.tag = "collected";

        }
    }
}
