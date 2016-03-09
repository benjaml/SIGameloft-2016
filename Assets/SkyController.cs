using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkyController : MonoBehaviour {

	public Slider timeSlider;
	public Material skyboxMat;
	public Material[] cloudsMaterials;
	public Light sun;

	public Color sunNightColor;
	public Color sunNoonColor;
	public Color sunDayColor;

	public Texture[] skyboxGradients;

	public float daySpeed;

	private float currentTime = 0;
	private float dayTimer = 0;
    private float cloudsTimer = 0;

    public bool backward = false;

    void Start()
    {
        sun.color = sunDayColor;
        sun.intensity = 1f;

        for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
        {
            cloudsMaterials[i].SetFloat("_BoolAfternoon", 0);
            cloudsMaterials[i].SetFloat("_BoolDay", 1);
            cloudsMaterials[i].SetFloat("_LightTransitionSlider", 1);
        }
    }

	void Update()
	{
		dayTimer += Time.deltaTime * daySpeed;
        cloudsTimer += Time.deltaTime * daySpeed;
        currentTime = dayTimer * 0.1f;


        if (backward == false)
        {
            Forward();
        }
       /* else if (backward == true)
        {
            Backward();
        }*/
	}

    void Forward()
    {
        Debug.Log("FORWAAAAAAAAAAAAAAAAAAAAAARD");

        if (currentTime <= 1)
        {
            skyboxMat.SetFloat("_TimeSlider", currentTime * 1000);
        }

        for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
        {
            cloudsMaterials[i].SetFloat("_CloudsMouvSlider", cloudsTimer);
        }

        if (currentTime <= 0.2f)
        {
            sun.color = sunDayColor;
            sun.intensity = 1f;

            for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
            {
                cloudsMaterials[i].SetFloat("_BoolAfternoon", 0);
                cloudsMaterials[i].SetFloat("_BoolDay", 1);
                //cloudsMaterials[i].SetFloat("_LightTransitionSlider",Mathf.Lerp(0f,1f,(currentTime-0.2f)*2f));
            }
            cloudsMaterials[2].SetFloat("_StarsAlpha", 0);
        }
        else if (currentTime >= 0.2f && currentTime <= 0.5f)
        {
            sun.color = Color.Lerp(sunDayColor, sunNoonColor, (currentTime - 0.2f) * 4f);
            sun.intensity = Mathf.Lerp(1f, 0.8f, (currentTime - 0.2f) * 4f);

            for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
            {
                cloudsMaterials[i].SetFloat("_BoolAfternoon", 1);
                cloudsMaterials[i].SetFloat("_BoolDay", 1);
                cloudsMaterials[i].SetFloat("_LightTransitionSlider", Mathf.Lerp(0f, 1f, (currentTime - 0.2f) * 4f));
            }
            cloudsMaterials[2].SetFloat("_StarsAlpha", 0);
        }
        else if (currentTime >= 0.6f && currentTime <= 0.9f)
        {
            sun.color = Color.Lerp(sunNoonColor, sunNightColor, (currentTime - 0.6f) * 4f);
            sun.intensity = Mathf.Lerp(0.8f, 0.4f, (currentTime - 0.6f) * 4f);

            for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
            {
                cloudsMaterials[i].SetFloat("_BoolAfternoon", 1);
                cloudsMaterials[i].SetFloat("_BoolDay", 0);
                cloudsMaterials[i].SetFloat("_LightTransitionSlider", Mathf.Lerp(0f, 1f, (currentTime - 0.6f) * 4f));
                cloudsMaterials[i].SetFloat("_CloudLightness", Mathf.Lerp(1f, 0.5f, (currentTime - 0.6f) * 4f));
            }
        }

        else if (currentTime >= 1.5f)
        {
            dayTimer = 0;
            backward = true;
        }
    }

    void Backward()
    {

        if (currentTime <= 1)
        {
            skyboxMat.SetFloat("_TimeSlider", 1000 - (currentTime * 1000));
        }

        for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
        {
            cloudsMaterials[i].SetFloat("_CloudsMouvSlider", cloudsTimer);
        }

        if (currentTime <= 0.2f)
        {
            sun.color = sunNightColor;
            sun.intensity = 0.4f;

            for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
            {
                //cloudsMaterials[i].SetFloat("_BoolAfternoon", 1);
                //cloudsMaterials[i].SetFloat("_BoolDay", 0);
                //cloudsMaterials[i].SetFloat("_LightTransitionSlider",Mathf.Lerp(1f,0f,(currentTime-0.2f)*2f));
            }
        }
        else if (currentTime >= 0.2f && currentTime <= 0.5f)
        {
            sun.color = Color.Lerp(sunNightColor, sunNoonColor, (currentTime - 0.2f) * 4f);
            sun.intensity = Mathf.Lerp(0.4f, 0.8f, (currentTime - 0.2f) * 4f);

            for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
            {
                cloudsMaterials[i].SetFloat("_BoolAfternoon", 1);
                cloudsMaterials[i].SetFloat("_BoolDay", 1);
                cloudsMaterials[i].SetFloat("_LightTransitionSlider", Mathf.Lerp(1f, 0f, (currentTime - 0.2f) * 4f));
            }
            //cloudsMaterials[2].SetFloat("_StarsAlpha", 0);
        }
        else if (currentTime >= 0.6f && currentTime <= 0.9f)
        {
            sun.color = Color.Lerp(sunNoonColor, sunDayColor, (currentTime - 0.6f) * 4f);
            sun.intensity = Mathf.Lerp(0.8f, 1f, (currentTime - 0.6f) * 4f);

            for (int i = 0; i <= cloudsMaterials.Length - 1; i++)
            {
                cloudsMaterials[i].SetFloat("_BoolAfternoon", 0);
                cloudsMaterials[i].SetFloat("_BoolDay", 1);
                cloudsMaterials[i].SetFloat("_LightTransitionSlider", Mathf.Lerp(1f, 0f, (currentTime - 0.6f) * 4f));
                cloudsMaterials[i].SetFloat("_CloudLightness", Mathf.Lerp(1f, 0.5f, (currentTime - 0.6f) * 4f));
            }
        }

        if (currentTime >= 1.5f)
        {
            dayTimer = 0;
            backward = false;
        }
    }
}
