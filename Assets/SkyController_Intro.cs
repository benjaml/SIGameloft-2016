using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkyController_Intro : MonoBehaviour
{

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

    public float transitionTime01 = 0;
    public float transitionTime02 = 0;

    private bool trans01 = false;
    private bool trans02 = false;

    private float cloudsTimer = 0f;
    private float lerpTimer = 0f;

    private int i = 0;
    private bool runTime = true;

    private float introTimer = 0;

    void Start()
    {
        sun.color = sunColors[actualTime];
        sun.intensity = sunIntensity[actualTime];
        skyboxMat.SetFloat("_TimeSlider", 50 + 200 * actualTime);

        for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
        {
            cloudsMaterials[i].SetColor("_SunColor", cloudColorsLight[actualTime]);
            cloudsMaterials[i].SetColor("_ShadowColor", cloudColorsShadow[actualTime]);
        }

        if (actualTime == 0)
        {
            skyboxMat.SetFloat("_StarsOpacity", 0.5f);
        }
        else
        {
            skyboxMat.SetFloat("_StarsOpacity", 0f);
        }

        StartCoroutine(RunningTime());
    }

    IEnumerator RunningTime()
    {
        while (runTime == true)
        {
            introTimer += Time.deltaTime;
            cloudsTimer += Time.deltaTime * daySpeed;

            for (int j = 0; j <= cloudsMaterials.Length - 1; j++)
            {
                cloudsMaterials[j].SetFloat("_CloudsMouvSlider", cloudsTimer);
            }

            if (introTimer >= transitionTime02 && trans02 == false)
            {
                Debug.Log("trans02");
                trans02 = true;
                StartCoroutine(DayCycle(1));
            }
            else if(introTimer >= transitionTime01 && trans01 == false)
            {
                trans01 = true;
                Debug.Log("trans01");
                StartCoroutine(DayCycle(0));
            }
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
            skyboxMat.SetFloat("_TimeSlider", Mathf.Lerp(50 + 200 * dayTime, 50 + 200 * (dayTime + 1), lerpTimer * transitionSpeed));

            for (int j = 0; j <= cloudsMaterials.Length - 1; j++)
            {
                cloudsMaterials[j].SetColor("_SunColor", Color.Lerp(cloudColorsLight[dayTime], cloudColorsLight[dayTime + 1], lerpTimer * transitionSpeed));
                cloudsMaterials[j].SetColor("_ShadowColor", Color.Lerp(cloudColorsShadow[dayTime], cloudColorsShadow[dayTime + 1], lerpTimer * transitionSpeed));
            }

            if (dayTime == 0)
            {
                skyboxMat.SetFloat("_StarsOpacity", Mathf.Lerp(0.5f, -0.5f, lerpTimer * transitionSpeed));
            }
            else
            {
                skyboxMat.SetFloat("_StarsOpacity", 0);
            }

            yield return null;
        }
        actualTime = dayTime + 1;
    }
}
