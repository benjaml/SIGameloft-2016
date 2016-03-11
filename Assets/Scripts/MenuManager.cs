using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

    public CanvasGroup menuInGame;
    private bool opened = false;

    void Start()
    {
        opened = false;
        menuInGame.alpha = 0;
        menuInGame.interactable = false;

    }

	void Update () {

	
        if(Input.GetButtonDown("Start_0") && opened == false)
        {
            Debug.Log("hello");

            Time.timeScale = 0;
            menuInGame.alpha = 1;
            menuInGame.interactable = true;
            //menuInGame.SetActive(true);
            opened = true;
            return;
        }
        if (Input.GetButtonDown("Start_0") && opened == true)
        {
            menuInGame.alpha = 0;
            menuInGame.interactable = false;
            //menuInGame.SetActive(false);
            opened = false;
            Time.timeScale = 1;
            return;
        }
    }

    public void resume()
    {
        menuInGame.alpha = 0;
        menuInGame.interactable = false;
        //menuInGame.SetActive(false);
        opened = false;
        Time.timeScale = 1;
        return;
    }

    public void quit ()
    {
        Application.Quit();
    }

    public void reload ()
    {

    }

   
}
