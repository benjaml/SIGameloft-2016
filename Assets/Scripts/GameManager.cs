using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public bool startUiOpened;
    public bool deathUiOpened;
    public GameObject startUi;
    public GameObject deathUi;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(gameObject);
        }
    }
    void Start()
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
    void loadLevel(int _numScene)
    {
        SceneManager.LoadScene(_numScene);
    }
    public void win()
    {
        //load win scene
    }
    public void lose()
    {
        //load lose scene
    }

    IEnumerator openStartUI()
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