﻿using UnityEngine;
using System.Collections;

/*
 * Comment émettre un event:
		SoundManagerEvent.emit(SoundManagerType.ENEMY_HIT);
 * 
 * Comment traiter un event (dans un start ou un initialisation)
		EventManagerScript.onEvent += (EventManagerType emt, GameObject go) => {
			if (emt == EventManagerType.ENEMY_HIT)
			{
				//SpawnFXAt(go.transform.position);
			}
		};
 * ou:
		void maCallback(EventManagerType emt, GameObject go) => {
			if (emt == EventManagerType.ENEMY_HIT)
			{
				//SpawnFXAt(go.transform.position);
			}
		};
		EventManagerScript.onEvent += maCallback;
 * 
 * qui permet de:
		EventManagerScript.onEvent -= maCallback; //Retire l'appel
 */


public enum SoundManagerType
{
    //Sounds
    //Character
    Diving, //Script pas mergés
    Jump, //OK (pas testé)
    Flying, // A faire boucler ? Je sais pas où le mettre.
    Straff, // Comment je fais boucler ?
    Damage, //OK (pas testé)
    //Dragon
    Anrgy, // Pas de script ?
    Suffering, //Pas de script 
        //Bells
    Gong, //Script pas mergé
    Bell, //Script pas mergé 
        //Flowers
    Flower, //Script pas mergé, comment qu'on fait pour faire plusieurs sons ?
        //Environment 
    Stream, //Je sais pas où mettre
    Thunder, //Je sais pas où mettre

    //Voice
        //Character
    Talk, //Je sais pas où mettre
}

public class SoundManagerEvent : MonoBehaviour
{
	public delegate void EventAction(SoundManagerType emt);
	public static event EventAction onEvent;

	#region Singleton
	static private SoundManagerEvent s_Instance;
	static public SoundManagerEvent instance
	{
		get
		{
			return s_Instance;
		}
	}
	


	void Awake()
	{
		if (s_Instance == null)
			s_Instance = this;
		//DontDestroyOnLoad(this);
	}
    #endregion
    void Start()
	{
		onEvent += (SoundManagerType emt) => {  };
	}

	public static void emit(SoundManagerType emt)	{
		
		if (onEvent != null)
		{
			onEvent(emt);
		}
	}



}
