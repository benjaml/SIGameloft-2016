using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkyController02 : MonoBehaviour {

	//public Slider timeSlider;
	public Material skyboxMat;
	public Material[] cloudsMaterials;
    public Light sun;

    public Color[] sunColors;
    public Color[] cloudColorsLight;
    public Color[] cloudColorsShadow;

	public float daySpeed;
    public float[] sunIntensity;
    public float transitionSpeed = 0;

    public int actualTime = 0;

    private float cloudsTimer = 0f;
    private float lerpTimer = 0f;

    private int i = 0;
    private bool runTime = true;

    void Start()
    {
        sun.color = sunColors[actualTime];
        sun.intensity = sunIntensity[actualTime];
        skyboxMat.SetFloat("_TimeSlider", 60 + 200 * actualTime);

        for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
        {
            cloudsMaterials[i].SetColor("_SunColor", cloudColorsLight[actualTime]);
            cloudsMaterials[i].SetColor("_ShadowColor", cloudColorsShadow[actualTime]);
        }

        if (actualTime == 3)
        {
            skyboxMat.SetFloat("_StarsOpacity", 0.5f);
        }
        else
        {
            skyboxMat.SetFloat("_StarsOpacity", 0f);
        }

        StartCoroutine(RunningTime());
    }

    public void startDayCycle(int dayTime)
    {
        StartCoroutine(DayCycle(dayTime));
    }

	IEnumerator RunningTime()
	{
        while (runTime == true)
        {
            cloudsTimer += Time.deltaTime * daySpeed;

            for (int j = 0; j <= cloudsMaterials.Length - 1; j++)
            {
                cloudsMaterials[j].SetFloat("_CloudsMouvSlider", cloudsTimer);
            }

            /*if (Input.anyKeyDown)
            {
                StartCoroutine(DayCycle(actualTime));
            }*/
            yield return null;
        }
	}

    IEnumerator DayCycle(int dayTime)
    {
        //dayTime is the time of day -> 0 is morning, 1 is miday, 2 is noon, 3 is night and 4 is sunrise. 
        lerpTimer = 0;
        while (lerpTimer * transitionSpeed < 1)
        {
            lerpTimer += Time.deltaTime;
            sun.color = Color.Lerp(sunColors[dayTime], sunColors[dayTime + 1], lerpTimer * transitionSpeed);
            sun.intensity = Mathf.Lerp(sunIntensity[dayTime], sunIntensity[dayTime + 1], lerpTimer * transitionSpeed);
            skyboxMat.SetFloat("_TimeSlider", Mathf.Lerp(60 + 200 * dayTime, 60 + 200 * (dayTime + 1), lerpTimer * transitionSpeed));

            for (int j = 0; j <= cloudsMaterials.Length - 1; j++)
            {
                cloudsMaterials[j].SetColor("_SunColor", Color.Lerp(cloudColorsLight[dayTime], cloudColorsLight[dayTime + 1], lerpTimer * transitionSpeed));
                cloudsMaterials[j].SetColor("_ShadowColor", Color.Lerp(cloudColorsShadow[dayTime], cloudColorsShadow[dayTime + 1], lerpTimer * transitionSpeed));
            }

            if(dayTime == 2)
            {
                skyboxMat.SetFloat("_StarsOpacity", Mathf.Lerp(-0.5f, 0.5f, lerpTimer * transitionSpeed));
            }
            else if(dayTime == 3)
            {
                skyboxMat.SetFloat("_StarsOpacity", Mathf.Lerp(0.5f, -0.5f, lerpTimer * transitionSpeed));
            }
            else
            {
                skyboxMat.SetFloat("_StarsOpacity", 0);
            }

            yield return null;
        }
        //actualTime = dayTime + 1;
    }
}
