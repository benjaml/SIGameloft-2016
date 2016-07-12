
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public CanvasGroup End;
    public CanvasGroup End_2;

    public static GameManager instance = null;
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
    void loadLevel(int _numScene)
    {
        SceneManager.LoadScene(_numScene);
    }
    public void win()
    {

        StartCoroutine("EndPanel");
      
    }
    public void lose()
    {
		//loadLevel(1);
    }

    IEnumerator EndPanel ()
    {
        while (End.alpha < 1)
        {
            End.alpha += 0.04f ;
            End_2.alpha += 0.04f;
            yield return new WaitForSeconds(0.03f);
        }
        Time.timeScale = 0;
        yield return null;
    }
}