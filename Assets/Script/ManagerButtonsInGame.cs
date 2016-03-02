using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ManagerButtonsInGame : MonoBehaviour {

    //When "Replay" is pressed, this fonction re-load the game scene (index 1).
    public void Replay(int indexOfScene)
    {
        SceneManager.LoadScene(indexOfScene);  //Loading the scene of the game (index 1)
    }

    //When "Exit" is pressed, the game is closed.
    public void Exit()
    {
        Application.Quit();
    }

    //When "Controls" is pressed, this fonction re-load the game scene (index 1).
    public void Controls()
    {

    }

    //When "Credits" is pressed, a scheme of the controls shows up on the current scene.
    public void CreditsPressed(int indexOfScene)
    {
        SceneManager.LoadScene(indexOfScene);  //Loading the scene of the game (index 2)
    }
}
