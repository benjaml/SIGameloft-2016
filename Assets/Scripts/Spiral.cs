using UnityEngine;
using System.Collections;

public class Spiral : MonoBehaviour
{

    public float minY;
    public float maxY;

    // Use this for initialization
    void Start ()
    {
        minY = transform.GetChild(0).transform.position.y;
        maxY = transform.GetChild(1).transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
