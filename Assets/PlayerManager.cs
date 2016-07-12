using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public static PlayerManager instance = null;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (this);
	}

	private GameObject playerCache = null;

	public GameObject getPlayer()
	{
		if (playerCache != null)
			return playerCache;
		else
		{
			playerCache = GameObject.FindGameObjectWithTag ("Player");
			return playerCache;
		}
	}

}
