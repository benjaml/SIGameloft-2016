using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{
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
        //load win scene
    }
    public void lose()
    {
        loadLevel(1);
    }
}