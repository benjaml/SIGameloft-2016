using UnityEngine;
using UnityStandardAssets.ImageEffects;
using System.Collections;

public class GameManagerWrath : MonoBehaviour
{


    public static GameManagerWrath instance = null;
    public GameObject player;                       //Le gameObject du joueur 
    private Material[] dragonsMat;                  // Material/shader du dragon
    public float maxWrath = 500;
    [Range(0, 500)]
    public float wrath;
    private float wrathLast = -1;
    private float wrathVelocity = 0.0f;
    public float smoothWrath = 0.3f;
    public float wrathAugementationByTick = 5f;     //
    public float timeBetweenTick = 0.3f;
    private bool freeze = false;

    public int numberOfCollectibles;

    //Call this function and delete the Start when you want to start the game
    //public void startGame ()
    //{
    //    StartCoroutine(wrathAugmentation());
    //}

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(this);
        }
        DontDestroyOnLoad(gameObject);
        player = GameObject.FindGameObjectWithTag("Player");
        GameObject[] dragons = GameObject.FindGameObjectsWithTag("Dragon");

        int i = 0;
        dragonsMat = new Material[dragons.Length];
        foreach (GameObject _dragonGO in dragons)
        {
            dragonsMat[i] = _dragonGO.GetComponent<MeshRenderer>().material;
            i++;
        }
    }

    void OnLevelWasLoaded(int level)
    {
        if (level == 0)
        {
            player = GameObject.FindGameObjectWithTag("Player");

            GameObject[] dragons = GameObject.FindGameObjectsWithTag("Dragon");

            int i = 0;
            dragonsMat = new Material[dragons.Length];
            foreach (GameObject _dragonGO in dragons)
            {
                dragonsMat[i] = _dragonGO.GetComponent<MeshRenderer>().material;
                i++;
            }

            wrath = 0;
        }

    }
    void Start()
    {
        StartCoroutine(wrathAugmentation());
    }

    void Update()
    {
        if (wrath == maxWrath / 2)
        {
            SoundManagerEvent.emit(SoundManagerType.Anrgy);
        }
        if (wrathLast != wrath)
        {
            wrathLast = wrath;
            //Debug.Log(wrath);
        }

        if (wrath == maxWrath)
            GameManager.instance.lose();

        if (wrath > maxWrath)
            wrath = maxWrath;

        foreach (Material _matDragon in dragonsMat)
        {
            float newPosition = Mathf.SmoothDamp(_matDragon.GetFloat("_Madness"), wrath, ref wrathVelocity, smoothWrath) / 500f;
            _matDragon.SetFloat("_Madness", wrath / 500f);
        }
    }

    public void wrathManaging()
    {
        if (numberOfCollectibles <= 0)
            return;
        else if (numberOfCollectibles <= 5)
            wrath -= 50;

        else if (numberOfCollectibles <= 10)
            wrath -= 100;

        else if (numberOfCollectibles <= 15)
            wrath -= 150;

        else if (numberOfCollectibles <= 20)
            wrath -= 200;

        foreach (Material _matDragon in dragonsMat)
        {
            _matDragon.SetFloat("_Madness", wrath / 500f);
        }
    }

    public void freezeWrath()
    {
        freeze = true;
    }
    public void continueWrath()
    {
        freeze = false;
    }

    IEnumerator wrathAugmentation()
    {
        while (true)
        {
            if (!freeze)
            {
                wrath += wrathAugementationByTick;
                if (wrath > (3 * maxWrath) / 4 && wrath <= maxWrath)
                    Camera.main.GetComponent<VignetteAndChromaticAberration>().intensity = ((wrath - (3 * maxWrath / 4)) / (maxWrath / 4));
                if (wrath < (3 * maxWrath) / 4)
                    Camera.main.GetComponent<VignetteAndChromaticAberration>().intensity = 0.0f;
            }
            yield return new WaitForSeconds(timeBetweenTick);
        }
    }

}
