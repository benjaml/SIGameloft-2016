using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour {

    public Animator m_MenuAnimator;

    public void Transition_To_Menu()
    {
        m_MenuAnimator.SetTrigger("Transition_To_Menu");
    }

    public void Main_To_Options()
    {
        m_MenuAnimator.SetTrigger("Main_To_Options");
    }

    public void Options_To_Main()
    {
        m_MenuAnimator.SetTrigger("Options_To_Main");
    }

    public void Continue_To_Main()
    {
        m_MenuAnimator.SetTrigger("Continue_To_Main");
    }

    public void Main_To_Continue()
    {
        m_MenuAnimator.SetTrigger("Main_To_Continue");
    }

    public void Main_To_Credits()
    {
        m_MenuAnimator.SetTrigger("Main_To_Credits");
    }

    public void Credits_To_Main()
    {
        m_MenuAnimator.SetTrigger("Credits_To_Main");
    }
}
