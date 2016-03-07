﻿using UnityEngine;
using System.Collections;

public class BlocSpeedModifier : MonoBehaviour {

    private float modifierSpeed = 2;

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Player")
        {
            PlayerMovement Script = col.gameObject.transform.parent.GetComponent<PlayerMovement>();
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Script.reduceCurrentSpeed(modifierSpeed);
            StartCoroutine(destructionBloc());
        }
    }

    IEnumerator destructionBloc()
    {
        int _tmp = 0;
        while (_tmp < 20)
        {
            _tmp++;
            yield return new WaitForEndOfFrame();
        }
        Destroy(gameObject);
        yield return null;

    }

}
