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

    //Variable to stock the gameManagerWrath
    private GameManagerWrath gameManagerWrath;

    void Start()
    {

        gameManagerWrath = GameManagerWrath.instance;
    }


    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "bell")
        {
            GameManagerWrath wrathManagmementFunction = gameManagerWrath.GetComponent<GameManagerWrath>();

            //Set the lenght of the list as the number of collectibles
            wrathManagmementFunction.numberOfCollectibles = GetComponent<PlayerCollectible>().listCollectible.Count;
            Debug.Log(wrathManagmementFunction.numberOfCollectibles);

            //Start the function to reduce the wrath gauge of the dragon
            wrathManagmementFunction.wrathManaging();


            //Clear the list with fx
        }
    }
}
