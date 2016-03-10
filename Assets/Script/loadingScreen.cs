using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class loadingScreen : MonoBehaviour {

	public GameObject background;
	public GameObject progressBar;
	private int loadProgress = 0;

	// Use this for initialization
	void Start () {
		background.SetActive (false);
		progressBar.SetActive (false);
	}
	

	public void load(string level){
		StartCoroutine(DisplayLoadingScreen(level));
	}

	IEnumerator DisplayLoadingScreen(string level){

		background.SetActive (true);
		progressBar.SetActive (true);
		
		AsyncOperation async = Application.LoadLevelAsync (level);
		while (!async.isDone) {
			progressBar.GetComponent<Image>().fillAmount = async.progress;
			yield return null;
		}
	}
}
