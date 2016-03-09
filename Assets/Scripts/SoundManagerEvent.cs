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
    Diving, //avec le fx de dive
    Jump, //OK (pas testé)
    Flying, // A faire boucler ? Quand isGrounded == false
    Straff, // Comment je fais boucler ? Quand les joystick marchent
    Damage, //OK (pas testé)

    //Dragon
    Anrgy, //Quand il passe en énervé (définir la valeur)
    Suffering, //Quand fresco == true

        //Bells
    Gong, //Collision gong
    Bell, //collision bell
        //Flowers
    Flower, //Script pas mergé, comment qu'on fait pour faire plusieurs sons ?
        //Environment 
    Stream, //quand isGrounded
    Thunder, //Je sais pas où mettre

    //Voice
        //Character
    Talk, //Une fois qu'on a récupérer 5 fleurs.
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
