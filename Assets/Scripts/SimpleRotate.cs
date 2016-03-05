using UnityEngine;
using System.Collections;

public class SimpleRotate : MonoBehaviour {

    public Vector3 m_Vector;

    public float m_Speed; 
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(m_Vector, m_Speed * Time.deltaTime);
    }
}
