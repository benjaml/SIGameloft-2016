using UnityEngine;
using System.Collections;

public class loadLevel : MonoBehaviour {

	public string level;
	public void HandleClick(){
		GameObject.FindGameObjectWithTag("loading").GetComponent<loadingScreen>().load(level);
	}
	public void HandleClickCompo(){
		Application.LoadLevel(level);
	}
	public void reset(){
		int rand = Random.Range (1, 5);
		while (rand == PlayerPrefs.GetInt("lastScene")) {
			rand = Random.Range (1, 5);
		}
		GameObject.FindGameObjectWithTag("loading").GetComponent<loadingScreen>().load("sceneLevel0"+rand);
		PlayerPrefs.SetInt("lastScene",rand);
	}
}
