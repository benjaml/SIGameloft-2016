using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkyController : MonoBehaviour {

	public Slider timeSlider;
	public Material skyboxMat;
	public Material[] cloudsMaterials;
    public Light sun;

    public Color[] sunColors;
    public Color[] cloudColorsLight;
    public Color[] cloudColorsShadow;

	public float daySpeed;
    public float[] sunIntensity;
    public float transitionStart = 0;
    public float transitionSpeed = 0;

	private float dayTimer = 0f;
    private float cloudsTimer = 0f;
    private float transitionTime = 0f;

    private int i = 0;

    void Start()
    {
        sun.color = sunColors[0];
        sun.intensity = sunIntensity[0];

        for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
        {
            cloudsMaterials[i].SetColor("_SunColor", cloudColorsLight[0]);
            cloudsMaterials[i].SetColor("_ShadowColor", cloudColorsShadow[0]);
        }
    }

	void Update()
	{
        dayTimer += Time.deltaTime * daySpeed * 0.1f;
        cloudsTimer += Time.deltaTime * daySpeed;

        for (int j = 0; j <= cloudsMaterials.Length - 1; j++)
        {
            cloudsMaterials[j].SetFloat("_CloudsMouvSlider", cloudsTimer);
        }

        if (dayTimer <= 1)
        {
            skyboxMat.SetFloat("_TimeSlider", dayTimer * 1000f);
        }

        DayCycle();
	}

    void DayCycle()
    {

        transitionTime = 1f/sunColors.Length;

        if(i < sunColors.Length)
        { 

            if (dayTimer <= transitionTime + (transitionTime * i))
            {
                if (dayTimer >= transitionTime/transitionStart + (transitionTime * i) && i < sunColors.Length -1)
                {
                    sun.color = Color.Lerp(sunColors[i], sunColors[i + 1], (dayTimer - (transitionTime / transitionStart + (transitionTime * i))) * sunColors.Length * transitionSpeed);
                    sun.intensity = Mathf.Lerp(sunIntensity[i], sunIntensity[i + 1], (dayTimer - (transitionTime / transitionStart + (transitionTime * i))) * sunColors.Length * transitionSpeed);

                    for (int j = 0; j <= cloudsMaterials.Length - 1; j++)
                    {
                        cloudsMaterials[j].SetColor("_SunColor", Color.Lerp(cloudColorsLight[i], cloudColorsLight[i + 1], (dayTimer - (transitionTime/transitionStart + (transitionTime * i))) * sunColors.Length * transitionSpeed));
                        cloudsMaterials[j].SetColor("_ShadowColor", Color.Lerp(cloudColorsShadow[i], cloudColorsShadow[i + 1], (dayTimer - (transitionTime / transitionStart + (transitionTime * i))) * sunColors.Length * transitionSpeed));
                    }
                }
            }
            else if (dayTimer > transitionTime + (transitionTime * i))
            {
                i++;
            }
        }
    }
}
