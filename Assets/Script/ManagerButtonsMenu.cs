using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ManagerButtonsMenu : MonoBehaviour {
	
        //When "Play" is pressed, this fonction load the game scene (index 1).
    public void JoinPressed()
    {
        SceneManager.LoadScene(1);  //Loading the scene of the game (index 1)
    }

        //When "Controls" is pressed, a scheme of the controls shows up on the current scene.
    public void ControlsPressed()
    {

    }
}
