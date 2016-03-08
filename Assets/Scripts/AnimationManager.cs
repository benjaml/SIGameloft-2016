using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour {

    public Animator m_MenuAnimator;
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Main_To_Options()
    {
        m_MenuAnimator.SetTrigger("Main_To_Options");
    }

    public void Options_To_Main()
    {
        m_MenuAnimator.SetTrigger("Options_To_Main");
    }
}
