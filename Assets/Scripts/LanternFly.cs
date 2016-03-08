using UnityEngine;
using System.Collections;

public class LanternFly : MonoBehaviour {

    private float m_Speed;
	
    void Start()
    {
        Destroy(gameObject, 60);

        m_Speed = Random.Range(4, 7);
    }

	// Update is called once per frame
	void Update () {

        transform.position += Vector3.up * Time.deltaTime * m_Speed;
    }
}
