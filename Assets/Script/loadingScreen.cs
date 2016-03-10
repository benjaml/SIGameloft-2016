using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class loadingScreen : MonoBehaviour {

	public GameObject background;
	public GameObject text;
	public GameObject progressBar;
	public GameObject goToMask;
	public Sprite[] listOfChoupis;
	public float rotationSpeed;
	public Vector3 rot;
	private int loadProgress = 0;

	// Use this for initialization
	void Start () {
		goToMask = GameObject.FindGameObjectWithTag ("DELETEME");
		background.SetActive (false);
		text.SetActive (false);
		progressBar.SetActive (false);
		progressBar.GetComponent<Image>().sprite = listOfChoupis[Random.Range(0,listOfChoupis.Length)];
	}
	

	public void load(string level){
		StartCoroutine(DisplayLoadingScreen(level));
	}

	IEnumerator DisplayLoadingScreen(string level){

		background.SetActive (true);
		text.SetActive (true);
		progressBar.SetActive (true);
		goToMask.SetActive (false);

		progressBar.GetComponent<Image>().sprite = listOfChoupis[Random.Range(0,listOfChoupis.Length)];
		rot = new Vector3 (0.0f, 0.0f, 0.0f);
		rot.z += rotationSpeed;
		AsyncOperation async = Application.LoadLevelAsync (level);
		while (!async.isDone) {
			rot.z += rotationSpeed;
			progressBar.GetComponent<RectTransform>().eulerAngles = rot;
			yield return null;
		}
	}
}
