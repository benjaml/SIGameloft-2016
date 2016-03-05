using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ResetScene : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.tag);
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("biclette");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
