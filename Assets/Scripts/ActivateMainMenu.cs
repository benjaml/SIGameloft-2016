using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateMainMenu : MonoBehaviour {

    public CanvasGroup m_PanelToActivate;
    public CanvasGroup m_FaderIntro;
    public Canvas m_MyCanvas;
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ActivateFadeIntro()
    {
        StartCoroutine(FadeIntro());
        //GetComponent<Animator>().SetTrigger("SetFadeIntro");
    }

    public void ActivateMenu()
    {
        if (m_MyCanvas.GetComponent<ButtonManager>().m_ReadyToPlay == false)
        {
            StartCoroutine(FadeMenu());
            m_MyCanvas.GetComponent<ButtonManager>().EndOfIntroduction();
        }
    }

    public IEnumerator FadeMenu()
    {
        while (m_PanelToActivate.alpha < 1)
        {
            m_PanelToActivate.alpha += 0.05f;
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;
    }

    public IEnumerator FadeIntro()
    {
        while (m_FaderIntro.alpha > 0)
        {
            m_FaderIntro.alpha -= 0.025f;
            yield return new WaitForSeconds(0.025f);
        }
        yield return null;
    }
}
