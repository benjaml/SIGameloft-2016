using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ParticlePlayground;

public class PlayerBellCollision : MonoBehaviour {

    //Déroulement du script:
    //Lorsque le joueur collide avec la cloche [Trigger]: 
    //On lance son et FX de la cloche;
    //On récupère la liste de ses collectibles (pétales)[GetComponent list des pétales],
    //Selon leurs nombres [int] et via un système de paliers [switch ?] on diminue la jauge du de colère du dragon [int] (à récupérer sur un gameManager externe ?) 
    //On clear la liste + FX de clear si besoin. 

    //Variable to stock the gameManagerWrath
    private GameManagerWrath gameManagerWrath;
    private int nbFlower;

    public PlaygroundParticlesC fxBell_flowers;
    public PlaygroundParticlesC fxBell_2;


    public PlaygroundParticlesC fxGong_flowers;
    public PlaygroundParticlesC fxGong_2;

    void Start()
    {
        fxGong_flowers.enabled = false;
        fxGong_2.enabled = false;
        fxBell_flowers.enabled = false;
        fxBell_2.enabled = false;

        gameManagerWrath = GameManagerWrath.instance;

    }


    void OnTriggerEnter (Collider col)
    {
        #region Collision Bell
        if (col.tag == "bell")
        {
            SoundManagerEvent.emit(SoundManagerType.Bell);
            Invoke("dragonSound", 0.5f);
            GameManagerWrath wrathManagmementFunction = gameManagerWrath.GetComponent<GameManagerWrath>();
            nbFlower = GetComponent<PlayerCollectible>().listCollectible.Count - 1;

            //Set the lenght of the list as the number of collectibles
            wrathManagmementFunction.numberOfCollectibles = GetComponent<PlayerCollectible>().listCollectible.Count;

            //Start the function to reduce the wrath gauge of the dragon
            wrathManagmementFunction.wrathManaging();


            //Clear the list with fx

            GameObject _tmpObject = transform.GetChild(0).gameObject;

            if (GetComponent<PlayerCollectible>().listCollectible[GetComponent<PlayerCollectible>().listCollectible.Count - 1] != GetComponent<PlayerCollectible>().listCollectible[0])
            {

                for (int i = 1; i < GetComponent<PlayerCollectible>().listCollectible.Count-1; i++)
                {
                    Destroy(GetComponent<PlayerCollectible>().listCollectible[i].gameObject);
                }
                GetComponent<PlayerCollectible>().listCollectible.Clear();
            }
            GetComponent<PlayerCollectible>().listCollectible.Add(_tmpObject);
            GetComponent<PlayerCollectible>().lastObject = _tmpObject;

            StartCoroutine(fxBellEmission());
        }
        #endregion

        #region Collision Gong
        if (col.tag == "gong")
        {
            SoundManagerEvent.emit(SoundManagerType.Gong);
            GameManagerWrath wrathManagmementFunction = gameManagerWrath.GetComponent<GameManagerWrath>();

            //Set the lenght of the list as the number of collectibles
            wrathManagmementFunction.numberOfCollectibles = GetComponent<PlayerCollectible>().listCollectible.Count;
            Debug.Log(wrathManagmementFunction.numberOfCollectibles);

            //Start the function to reduce the wrath gauge of the dragon
            wrathManagmementFunction.wrathManaging();

            //Clear the list with fx

            GameObject _tmpObject = transform.GetChild(0).gameObject;

            if (GetComponent<PlayerCollectible>().listCollectible[GetComponent<PlayerCollectible>().listCollectible.Count - 1] != GetComponent<PlayerCollectible>().listCollectible[0])
            {
                for (int i = 1; i < GetComponent<PlayerCollectible>().listCollectible.Count-1; i++)
                {
                    Destroy(GetComponent<PlayerCollectible>().listCollectible[i].gameObject);
                }
                GetComponent<PlayerCollectible>().listCollectible.Clear();
            }

            GetComponent<PlayerCollectible>().listCollectible.Add(_tmpObject);
            GetComponent<PlayerCollectible>().lastObject = _tmpObject;

            StartCoroutine(fxGongEmission());

        }
        #endregion
    }

    IEnumerator fxBellEmission()
    {
        if (nbFlower > 0)
        {
            
            fxBell_flowers.enabled = true;
        }
        fxBell_2.enabled = true;
        yield return new WaitForSeconds(1.1f);
        fxBell_flowers.emit = false;
        fxBell_2.emit = false;
        yield return null;
    }

    IEnumerator fxGongEmission()
    {
        if (nbFlower > 0)
        {
            fxGong_flowers.enabled = true;
        }
        fxGong_2.enabled = true;
        yield return new WaitForSeconds(0.25f);
        fxGong_flowers.emit = false;
        fxGong_2.emit = false;
        yield return null;
    }

    void dragonSound()
    {
        SoundManagerEvent.emit(SoundManagerType.BellRung);
    }
}
