using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public AudioMixer mixer;
    public AudioMixerGroup first;
    public AudioMixerGroup second;

    private float firstVol = -30f;
    private float secondVol = 10f;

	// Use this for initialization
	void Start () {

        first = mixer.FindMatchingGroups("First")[0];
        second = mixer.FindMatchingGroups("Second")[0];

        mixer.SetFloat("FirstVolume", firstVol);
        mixer.SetFloat("SecondVolume", secondVol);
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.Keypad2))
        {
            if(firstVol < 10f && secondVol >= -30f)
            {
                firstVol ++;
                secondVol --;
                changeVolumeMixer();
            }
        }

        if (Input.GetKey(KeyCode.Keypad1))
        {
            if (firstVol >= -30f && secondVol < 10f)
            {
                firstVol --;
                secondVol ++;
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
