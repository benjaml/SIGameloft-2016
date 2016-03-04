using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBellCollision : MonoBehaviour {

    //Déroulement du script:
    //Lorsque le joueur collide avec la cloche [Trigger]: 
    //On lance son et FX de la cloche;
    //On récupère la liste de ses collectibles (pétales)[GetComponent list des pétales],
    //Selon leurs nombres [int] et via un système de paliers [switch ?] on diminue la jauge du de colère du dragon [int] (à récupérer sur un gameManager externe ?) 
    //On clear la liste + FX de clear si besoin. 


    //Liste provisoire pour les pétales:
    private List<GameObject> listProvisoireCollectible = new List<GameObject>();


    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "bell")
        {
           
        }
    }
}
