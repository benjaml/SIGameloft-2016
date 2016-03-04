using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool startUiOpened;
    public bool deathUiOpened;
    public GameObject startUi;
    public GameObject deathUi;
	
    void Start ()
    {
        startUiOpened = false;
        deathUiOpened = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            StartCoroutine(openStartUI());
        }

        if (Input.GetKeyDown("d"))
        {
            StartCoroutine(openDeathUI());
        }
    }
	
    IEnumerator openStartUI ()
    {
        if (startUiOpened == false && deathUiOpened == false)
        {
            startUi.SetActive(true);
            startUiOpened = true;
            yield break;
        }

        if (startUiOpened == true)
        {
            startUi.SetActive(false);
            startUiOpened = false;
            yield break;
        }

    }
    IEnumerator openDeathUI()
    {
        if (deathUiOpened == false && startUiOpened == false)
        {
            deathUi.SetActive(true);
            deathUiOpened = true;
            yield break;
        }

        if (deathUiOpened == true)
        {
            deathUi.SetActive(false);
            deathUiOpened = false;
            yield break;
        }

    }


}
