using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class EndFrescoSequence : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            col.transform.parent.GetComponent<PlayerMovement>().isFresco = false;
            GameObject _tmp = Camera.main.gameObject;
            _tmp.GetComponent<SmoothFollow>().isFresco = false;
        }
    }
}
