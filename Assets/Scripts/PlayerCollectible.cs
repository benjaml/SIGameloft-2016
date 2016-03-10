using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ParticlePlayground;



public class PlayerCollectible : MonoBehaviour {

    public List<GameObject> listCollectible = new List<GameObject>();
    public GameObject targetCollectible;
    public GameObject lastObject;
    public PlaygroundParticlesC fxTrailFlower;


    private float randomWidth; //x
    private float randomHeight; //y
    private float randomDistance; //z

    void Start ()
    {
        listCollectible.Add(targetCollectible);
        fxTrailFlower.enabled = false;
        fxTrailFlower.emit = false;
    }

    void Update()
    {
        if (listCollectible.Count < 2)
        {
            fxTrailFlower.enabled = false;
            fxTrailFlower.emit = false;
        }
    }

    void OnTriggerEnter (Collider col)
    {
      
        if (col.tag == "collectible")
        {
            fxTrailFlower.enabled = true;
            fxTrailFlower.emit = true;
            if (!listCollectible.Contains(col.gameObject))
            {
                listCollectible.Add(col.gameObject);
                lastObject = listCollectible[listCollectible.Count - 2];
            }
            SoundManagerEvent.emit(SoundManagerType.Flower);

            randomWidth = Random.Range(-3f, 3);
            randomHeight = Random.Range(-0.1f, 1);
            randomDistance = Random.Range(0.000f, 0.200f);

            
            col.transform.eulerAngles = targetCollectible.transform.eulerAngles;
            col.transform.position = new Vector3(targetCollectible.transform.position.x + randomWidth, 
                                                  lastObject.transform.position.y - 0.045f, 
                                                  lastObject.transform.position.z + randomDistance);

            col.GetComponent<CollectibleMovement>().offsetInitialisation();

            col.GetComponent<CollectibleMovement>().collected = true;
            col.transform.gameObject.tag = "collected";
            col.transform.gameObject.GetComponent<BoxCollider>().enabled = false;

        }
    }


}
