using UnityEngine;
using System.Collections;

public class CameraShader : MonoBehaviour {

    public GameObject GameManagerWrath;
    public GameObject windEffect;
    private float Opacity;
    private float Stripes;
    private float maxOpacity = 0.2f;
    

	public IEnumerator Acceleration () //FAIRE COROUTINE
    {
        if (GameManagerWrath.GetComponent<GameManagerWrath>().wrath > GameManagerWrath.GetComponent<GameManagerWrath>().maxWrath /2 )
        {
            maxOpacity = 0.5f;
        }
        if (GameManagerWrath.GetComponent<GameManagerWrath>().wrath <= GameManagerWrath.GetComponent<GameManagerWrath>().maxWrath / 2)
        {
            maxOpacity = 0.2f;
        }

        if (transform.GetChild(0).GetComponent<Renderer>().material.GetFloat("_Opacity") <= 0.1f)
        {

            while (transform.GetChild(0).GetComponent<Renderer>().material.GetFloat("_Opacity") < maxOpacity)
            {

                transform.GetChild(0).GetComponent<Renderer>().material.SetFloat("_Opacity", transform.GetChild(0).GetComponent<Renderer>().material.GetFloat("_Opacity") + 0.05f);
                yield return new WaitForSeconds(0.3f);
            }
        }
    }

    public IEnumerator ReduceShader ()
    {
        if (transform.GetChild(0).GetComponent<Renderer>().material.GetFloat("_Opacity") >= 0.1f)
        {
            while (transform.GetChild(0).GetComponent<Renderer>().material.GetFloat("_Opacity") >= 0.1f)
            {
                transform.GetChild(0).GetComponent<Renderer>().material.SetFloat("_Opacity", transform.GetChild(0).GetComponent<Renderer>().material.GetFloat("_Opacity") - 0.05f);
                yield return new WaitForSeconds(0.3f);
            }
        }
    }
}
