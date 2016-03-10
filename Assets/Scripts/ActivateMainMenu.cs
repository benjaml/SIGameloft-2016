using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateMainMenu : MonoBehaviour {

    public CanvasGroup m_PanelToActivate;
    public Canvas m_MyCanvas;
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ActivateMenu()
    {
        StartCoroutine(FadeMenu());
        m_MyCanvas.GetComponent<ButtonManager>().EndOfIntroduction();
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
}
