using UnityEngine;
using System.Collections;

public class PlayerBounceObstacles : MonoBehaviour {

    Vector3 m_ObjectPosition;
    Vector3 m_Direction;

    GameObject obstacle;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "obstacle")
        {
            obstacle = col.gameObject;
            Bump();
        }
    }

    void Bump()
    {
        m_ObjectPosition = new Vector3(obstacle.transform.position.x, obstacle.transform.position.y, obstacle.transform.position.z);
        m_Direction = m_ObjectPosition - transform.position;
        Debug.Log("hello...IS IT ME YOU'RE LOOKING FOOOOR");
        gameObject.GetComponent<Rigidbody>().AddForce( m_Direction * -1 * 35);
    }

}
