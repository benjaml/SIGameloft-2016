﻿using UnityEngine;
using System.Collections;
 
 public class winScript : MonoBehaviour
{ 
     void OnTriggerEnter(Collider col)
     {

        Debug.Log(col.name);
        if (col.tag == "Player")
        {
            Debug.Log("pop");
            GameManager.instance.win();
        }
     }
 
     // Use this for initialization
     void Start()
    {

    }
     
     // Update is called once per frame
     void Update()
    {
  
    }
}