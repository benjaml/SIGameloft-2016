using UnityEngine;
using System.Collections;

public class ShadowTrigger : MonoBehaviour {

	public GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void LateUpdate()
	{
		transform.position = player.transform.position;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Shadow") 
		{
			Debug.Log ("lol");
			col.GetComponent<MeshRenderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Shadow") 
		{
			col.GetComponent<MeshRenderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
		}
	}
}
