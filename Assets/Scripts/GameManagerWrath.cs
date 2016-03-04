using UnityEngine;
using System.Collections;

public class GameManagerWrath : MonoBehaviour {

    public GameObject player;
    [Range(0, 500)]
    public int wrath;
    private int wrathLast = -1;

    public int numberOfCollectibles;

    //Call this function and delete the Start when you want to start the game
    //public void startGame ()
    //{
    //    StartCoroutine(wrathAugmentation());
    //}
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start ()
    {
        StartCoroutine(wrathAugmentation());
    }

    void Update ()
    {
        if (wrathLast != wrath)
        {
            wrathLast = wrath;
            Debug.Log(wrath);
        }
    }

    public void wrathManaging()
    {
        if (numberOfCollectibles <= 0)
            return;
        else if (numberOfCollectibles <= 5)
            wrath -= 5;

        else if (numberOfCollectibles <= 10)
            wrath -= 2;

        else if (numberOfCollectibles <= 15)
            wrath -= 3;

        else if (numberOfCollectibles <= 20)
            wrath -= 4;
    }

    IEnumerator wrathAugmentation()
    {
        while (true)
        {
            wrath++;
            yield return new WaitForSeconds(0.5f);
        }

    }

}
