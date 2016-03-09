using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class StartFrescoSequence : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            col.transform.parent.GetComponent<PlayerMovement>().isFresco = true;
            GameObject _tmp = Camera.main.gameObject;
            _tmp.GetComponent<SmoothFollow>().isFresco = true;
        }
    }
}
