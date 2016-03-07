using UnityEngine;
using System.Collections;

public class ShakeManager : MonoBehaviour {
    #region Singleton
    static private ShakeManager s_Instance;
    static public ShakeManager instance
    {
        get
        {
            return s_Instance;
        }
    }

    void Awake()
    {
        mainCamera = Camera.main;
        if (s_Instance == null)
            s_Instance = this;
        //DontDestroyOnLoad(this);
    }
    #endregion

    #region members
    private float shakeAmt;
    public Camera mainCamera;

    private bool shake_up;
    private bool shake_left;

    Vector3 pp;
    #endregion

    public void LetsShake(float relative = 100, bool _shake_up = true, bool _shake_left = true)
    {
        shake_up=_shake_up;
        shake_left=_shake_left;
        
       
        shakeAmt = relative * .0025f;
        
        InvokeRepeating("CameraShake", 0, .05f);
        Invoke("StopShaking", 0.5f);

    }

   

    void CameraShake()
    {
        if (shakeAmt > 0)
        {
            float quakeAmt = Random.value * shakeAmt * 2 - shakeAmt;
            pp = mainCamera.transform.position;
            if(shake_up)
            {
                pp.y += quakeAmt * 1;
            }
            if(shake_left)
            {
                pp.x += quakeAmt * 1;
            }
            mainCamera.transform.position = pp;
        }
    }

    void StopShaking()
    {
        CancelInvoke("CameraShake");
        mainCamera.transform.position = new Vector3(0,6.7f,pp.z);
    }

}
