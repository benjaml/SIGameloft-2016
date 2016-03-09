using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public List<Button> m_MainMenuButtonsList;
    public List<Button> m_OptionsMenuButtonsList;
    public string m_CurrentPanel = "MainPanel";
    public int m_CurrentIndex = 0;

    // To link to the global volume of the game.
    public float m_Volume;

    public bool m_EndInput;

    public AnimationManager m_AnimationScript;

    public void Update()
    {
        // Check if the gamepad's stick is at its standby position. If True, the player can move the stick to interact with the menu.
        if (Input.GetAxis("L_YAxis_0") < 0.3f && Input.GetAxis("L_YAxis_0") > -0.3f)
        {
            m_EndInput = true;
        }

        CheckInputPositions();
    }

    public void CheckInputPositions()
    {
        // Check if the gamepad's stick is pushed (top) and if the player can interact. If True, the CurrentIndex decreases in order to get the upper button selected.
        if (Input.GetAxis("L_YAxis_0") < -0.3f && m_EndInput)
        {
            SelectUpperButton();
        }

        // Check if the gamepad's stick is pulled (bottom) and if the player can interact. If True, the CurrentIndex increases in order to get the lower button selected.
        if (Input.GetAxis("L_YAxis_0") > 0.3f && m_EndInput)
        {
            SelectLowerButton();
        }
    }

    // Is called when the stick is pushed.
    public void SelectUpperButton()
    {
        // If the index gonna reach its minimum value, we make it loops.
        if (m_CurrentIndex == 0)
        {
            if (m_CurrentPanel == "MainPanel")
            {
                m_CurrentIndex = m_MainMenuButtonsList.Count - 1;
            }
            if (m_CurrentPanel == "OptionsPanel")
            {
                m_CurrentIndex = m_OptionsMenuButtonsList.Count - 1;
            }
        }
        else
        {
            m_CurrentIndex--;
        }

        ActivateNewButton();
        m_EndInput = false;
    }

    // Is called when the stick is pulled.
    public void SelectLowerButton()
    {
        // If the index gonna reach its maximum value, we make it loops.
        if (m_CurrentPanel == "MainPanel")
        {
            if (m_CurrentIndex == m_MainMenuButtonsList.Count - 1)
            {
                m_CurrentIndex = 0;
            }
            else
            {
                m_CurrentIndex++;
            }
        }

        if (m_CurrentPanel == "OptionsPanel")
        {
            if (m_CurrentIndex == m_OptionsMenuButtonsList.Count - 1)
            {
                m_CurrentIndex = 0;
            }
            else
            {
                m_CurrentIndex++;
            }
        }

        ActivateNewButton();
        m_EndInput = false;
    }

    // Is called when a button is selected.
    public void ActivateNewButton()
    {
        if (m_CurrentPanel == "MainPanel")
        {
            m_MainMenuButtonsList[m_CurrentIndex].Select();
        }
        if (m_CurrentPanel == "OptionsPanel")
        {
            m_OptionsMenuButtonsList[m_CurrentIndex].Select();
        }
    }

    // Is called when a button is pressed.
    public void PressButton(int _buttonIndex)
    {
        Debug.Log("clic bouton " + _buttonIndex);

        // Actions linked to the Main Panel's buttons
        if (m_CurrentPanel == "MainPanel")
        {
            switch (_buttonIndex)
            {
                // Start
                case 0:
                    SceneManager.LoadScene("TO BE DEFINED");
                    break;
                // Levels
                case 1:
                    SceneManager.LoadScene("TO BE DEFINED");
                    break;
                // Options
                case 2:
                    m_CurrentPanel = "OptionsPanel";
                    m_CurrentIndex = 0;
                    m_MainMenuButtonsList[m_CurrentIndex].Select();
                    m_AnimationScript.Main_To_Options();
                    break;
                // Exit
                case 3:
                    SceneManager.LoadScene("TO BE DEFINED");
                    break;
            }
        }
        // Actions linked to the Options panel's buttons
        if (m_CurrentPanel == "OptionsPanel")
        {
            switch (_buttonIndex)
            {
                // Back to Main Menu
                case 0:
                    m_CurrentPanel = "MainPanel";
                    m_CurrentIndex = 0;
                    m_OptionsMenuButtonsList[m_CurrentIndex].Select();
                    m_AnimationScript.Options_To_Main();
                    break;
                // Decrease Volume
                case 1:
                    // Decrease the volume;
                    if (m_Volume != 0f)
                    {
                        m_Volume--;
                        m_OptionsMenuButtonsList[m_CurrentIndex].transform.parent.FindChild("TextVolume").GetComponent<Text>().text = m_Volume.ToString();
                    }
                    // Change the text, check if value isn't overiding the max and min values
                    break;
                // Increase Volume
                case 2:
                    // Decrease the volume;
                    if (m_Volume != 10f)
                    {
                        m_Volume++;
                        m_OptionsMenuButtonsList[m_CurrentIndex].transform.parent.FindChild("TextVolume").GetComponent<Text>().text = m_Volume.ToString();
                    }
                    // Change the text, check if value isn't overiding the max and min values
                    break;
            }
        }
    }




    ////When "Play" is pressed, this fonction load the game scene (index 1).
    //public void PlayPressed(int indexOfScene)
    //{
    //    SceneManager.LoadScene(indexOfScene);  //Loading the scene of the game (index 1)
    //}

    ////When "Replay" is pressed, this fonction re-load the game scene (index 1).
    //public void Replay(int indexOfScene)
    //{
    //    SceneManager.LoadScene(indexOfScene);  //Loading the scene of the game (index 1)
    //}

    ////When "Exit" is pressed, the game is closed.
    //public void Exit()
    //{
    //    Application.Quit();
    //}

    ////When "Controls" is pressed, this fonction re-load the game scene (index 1).
    //public void Controls()
    //{

    //}

    ////When "Credits" is pressed, a scheme of the controls shows up on the current scene.
    //public void CreditsPressed(int indexOfScene)
    //{
    //    SceneManager.LoadScene(indexOfScene);  //Loading the scene of the game (index 2)
    //}
}
