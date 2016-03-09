using UnityEngine;
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
    Diving, //OK (pas testé) index 9
    DiveOut, //OK (pas testé)  index 10
    Jump, //OK (pas testé) index 11
    Straff, // OK (pas testé) index 12
    Acceleration,//OK (pas testé) index 13

        //Dragon
    Anrgy, //OK (pas testé, valeur à définir) index 14
    Suffering, //OK (pas testé) index de 5 à 8
    BellRung, //OK (pas testé) index 15

        //Bells
    Gong, //OK (pas testé) index 16
    Bell, //OK (pas testé) index 17

        //Flowers
    Flower, //OK (pas testé) index 0 à 4

        //Environment   
    Impact, //OK (pas testé) index 18
    Stream, //A mettre en continu index 19
    Thunder, //Je sais pas où mettre

    //Voice
        //Character
    CharacterHurt, //OK (pas testé) index 0
    Talk, //OK (pas testé) index 1 à 5
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
