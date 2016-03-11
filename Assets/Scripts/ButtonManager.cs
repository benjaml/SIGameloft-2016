using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public List<Button> m_MainMenuButtonsList;
    public List<Button> m_OptionsMenuButtonsList;
    public List<Button> m_ContinueMenuButtonsList;
    public List<Button> m_CreditsMenuButtonsList;
    public string m_CurrentPanel = "MainPanel";
    public int m_CurrentIndex = 0;

    public GameObject m_PanelMainMenu;
    public bool m_ReadyToPlay = false;

    // To link to the global volume of the game.
    public float m_Volume;
    public Text m_TextVolume;

    public bool m_EndInput;

    public AnimationManager m_AnimationScript;

    public void Update()
    {
        if (m_ReadyToPlay)
        {
            // Check if the gamepad's stick is at its standby position. If True, the player can move the stick to interact with the menu.
            if (Input.GetAxis("L_YAxis_0") < 0.3f && Input.GetAxis("L_YAxis_0") > -0.3f)
            {
                m_EndInput = true;
            }

            CheckInputPositions();
        }
        else if (!m_ReadyToPlay)
        {
            if (Input.GetButton("A_0") || Input.GetButton("B_0"))
            {
                Camera.main.GetComponent<ActivateMainMenu>().ActivateMenu();
            }
        }
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
            else if (m_CurrentPanel == "OptionsPanel")
            {
                m_CurrentIndex = m_OptionsMenuButtonsList.Count - 1;
            }
            else if (m_CurrentPanel == "ContinuePanel")
            {
                m_CurrentIndex = m_ContinueMenuButtonsList.Count - 1;
            }
            else if (m_CurrentPanel == "CreditsPanel")
            {
                m_CurrentIndex = m_CreditsMenuButtonsList.Count - 1;
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

        else if (m_CurrentPanel == "OptionsPanel")
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

        else if (m_CurrentPanel == "ContinuePanel")
        {
            if (m_CurrentIndex == m_ContinueMenuButtonsList.Count - 1)
            {
                m_CurrentIndex = 0;
            }
            else
            {
                m_CurrentIndex++;
            }
        }

        else if (m_CurrentPanel == "CreditsPanel")
        {
            if (m_CurrentIndex == m_CreditsMenuButtonsList.Count - 1)
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
        else if (m_CurrentPanel == "OptionsPanel")
        {
            m_OptionsMenuButtonsList[m_CurrentIndex].Select();
        }
        else if (m_CurrentPanel == "ContinuePanel")
        {
            m_ContinueMenuButtonsList[m_CurrentIndex].Select();
        }
        else if (m_CurrentPanel == "CreditsPanel")
        {
            m_CreditsMenuButtonsList[m_CurrentIndex].Select();
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
                    SceneManager.LoadScene("Scene_1_2_3");
                    break;
                // Levels
                case 1:
                    m_CurrentPanel = "ContinuePanel";
                    m_CurrentIndex = 0;
                    m_AnimationScript.Main_To_Continue();
                    break;
                // Options
                case 2:
                    m_CurrentPanel = "OptionsPanel";
                    m_CurrentIndex = 0;
                    m_AnimationScript.Main_To_Options();
                    break;
                // Credits
                case 3:
                    m_CurrentPanel = "CreditsPanel";
                    m_CurrentIndex = 0;
                    m_AnimationScript.Main_To_Credits();
                    break;
                // Exit
                case 4:
                    Application.Quit();
                    break;
            }
        }
        // Actions linked to the Options panel's buttons
        else if (m_CurrentPanel == "OptionsPanel")
        {
            switch (_buttonIndex)
            {
                // Back to Main Menu
                case 0:
                    m_CurrentPanel = "MainPanel";
                    m_CurrentIndex = 0;
                    m_AnimationScript.Options_To_Main();
                    break;
                // Increase Volume
                case 1:
                    // Increase the volume;
                    if (m_Volume != 10f)
                    {
                        m_Volume++;
                        // Change the text, check if value isn't overiding the max and min values
                        m_TextVolume.text = m_Volume.ToString();
                    }
                    break;
                // Decrease Volume
                case 2:
                    // Decrease the volume;
                    if (m_Volume != 0f)
                    {
                        m_Volume--;
                        // Change the text, check if value isn't overiding the max and min values
                        m_TextVolume.text = m_Volume.ToString();
                    }
                    break;
            }
        }
        // Actions linked to the Continue Panel's buttons
        else if (m_CurrentPanel == "ContinuePanel")
        {
            switch (_buttonIndex)
            {
                // back to Main
                case 0:
                    m_CurrentPanel = "MainPanel";
                    m_CurrentIndex = 0;
                    m_AnimationScript.Continue_To_Main();
                    break;
                // Load Level 01
                case 1:
                    SceneManager.LoadScene("Scene_1_2_3");
                    break;
                // Load Level 02
                case 2:
                    SceneManager.LoadScene("Scene_2_3");
                    break;
                // Load Level 03
                case 3:
                    SceneManager.LoadScene("Scene_3");
                    break;
            }
        }
        // Actions linked to the Credits Panel's buttons
        else if (m_CurrentPanel == "CreditsPanel")
        {
            switch (_buttonIndex)
            {
                // back to Main
                case 0:
                    m_CurrentPanel = "MainPanel";
                    m_CurrentIndex = 0;
                    m_AnimationScript.Credits_To_Main();
                    break;
            }
        }
    }

    public void SelectMainButtonFromOptions()
    {
        m_MainMenuButtonsList[2].Select();
        m_CurrentIndex = 2;
    }

    public void SelectMainButtonFromContinue()
    {
        m_MainMenuButtonsList[1].Select();
        m_CurrentIndex = 1;
    }

    public void SelectOptionsTopButton()
    {
        m_OptionsMenuButtonsList[0].Select();
        m_CurrentIndex = 0;
    }

    public void SelectContinueButton()
    {
        m_ContinueMenuButtonsList[0].Select();
        m_CurrentIndex = 0;
    }

    public void SelectCreditsButton()
    {
        m_CreditsMenuButtonsList[0].Select();
        m_CurrentIndex = 0;
    }

    public void SelectMainButtonFromCredits()
    {
        m_MainMenuButtonsList[3].Select();
        m_CurrentIndex = 3;
    }


    // PENSER A METTRE LE SCRIPT ACTIVATE MAIN MENU SUR LA CAMERA DE L'ANIMATION
    // METTRE L'EVENT ANIM SUR L'ANIMATION D'INTRODUCTION
    public void EndOfIntroduction()
    {
        //m_PanelMainMenu.GetComponent<CanvasGroup>().alpha = 1;
        m_MainMenuButtonsList[0].Select();
        m_ReadyToPlay = true;
        m_CurrentIndex = 0;
    }
}
