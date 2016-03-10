using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public AudioMixer mixer;
    public AudioMixerGroup first;
    public AudioMixerGroup second;

    private float firstVol = 1f;
    private float secondVol = -40f;

	// Use this for initialization
	void Start () {

        first = mixer.FindMatchingGroups("First")[0];
        second = mixer.FindMatchingGroups("Second")[0];

        mixer.SetFloat("FirstVolume", firstVol);
        mixer.SetFloat("SecondVolume", secondVol);
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (GetComponent<GameManagerWrath>().wrath > 250)
        {
            if (secondVol <= 5)
            {
                firstVol --;
                secondVol ++;
                changeVolumeMixer();
            }
        }


        if (GetComponent<GameManagerWrath>().wrath < 250)
        {
            if (firstVol <= 2)
            {
                firstVol++;
                secondVol--;
                changeVolumeMixer();
            }
        }

    }

    void changeVolumeMixer()
    {
        mixer.SetFloat("FirstVolume", firstVol);
        mixer.SetFloat("SecondVolume", secondVol);
    }

}
