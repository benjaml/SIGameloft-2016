using UnityEngine;
using System.Collections;
using ParticlePlayground;

public class PlayerFx : MonoBehaviour {

    public PlaygroundParticlesC fxDiveFoam;

    //Right tilt
    public PlaygroundParticlesC fxRightTilt_1;

    //Left tilt
    public PlaygroundParticlesC fxLeftTilt_1;

    private bool diving = false;

    private bool isGrounded;

    void Start()
    {         fxDiveFoam.enabled = false;
        fxLeftTilt_1.enabled = false;
        fxRightTilt_1.enabled = false;
    }

    void Update ()
    {
        isGrounded = GetComponent<PlayerMovement>().isGrounded;

        if (Input.GetAxisRaw("R_YAxis_0") > 0.3 && isGrounded && !diving)
        {

            fxDiveFoam.enabled = true;
            fxDiveFoam.emit = true;
            SoundManagerEvent.emit(SoundManagerType.Diving);
            diving = true;
        }

        if (Input.GetAxisRaw("R_YAxis_0") < 0.3)
        {
            diving = false;
            fxDiveFoam.enabled = false;
            fxDiveFoam.emit = false;
        }



        //if (Input.GetAxisRaw("R_YAxis_0") < 0.1 && isGrounded)
        //{
        //    //StartCoroutine(fxDive());


        //}


        //Left tilt
        if (Input.GetAxisRaw("Horizontal") > 0.2f  && isGrounded)
        {
            fxRightTilt_1.enabled = true;
            fxRightTilt_1.emit = true;
            SoundManagerEvent.emit(SoundManagerType.Straff);



        }

        //if (Input.GetAxisRaw("R_YAxis_0") > 0 && Input.GetAxisRaw("R_YAxis_0") < 0.2f && isGrounded)
        //{
        //    SoundManagerEvent.emit(SoundManagerType.DiveOut);
        //}

        //Right tilt
        if (Input.GetAxisRaw("Horizontal") < -0.2f && isGrounded)
        {
            fxLeftTilt_1.enabled = true;
            fxLeftTilt_1.emit = true;



           
        }

        if (Input.GetAxisRaw("Horizontal") == 0  && isGrounded)
        {
            SoundManagerEvent.emit(SoundManagerType.Stream);
            StartCoroutine(fxTiltRight());
            StartCoroutine(fxTiltLeft());
        }


    }

    //IEnumerator fxDive()
    //{
    //    fxDiveFoam.emit = false;
    //    yield return new WaitForSeconds(0.5f);
    //    fxDiveFoam.enabled = false;
    //    yield return null;
    //}

    IEnumerator fxTiltRight()
    {

        fxRightTilt_1.emit = false;
        yield return new WaitForSeconds(0.5f);
        fxRightTilt_1.enabled = false;
        yield return null;
    }

    IEnumerator fxTiltLeft()
    {
        fxLeftTilt_1.emit = false;
        yield return new WaitForSeconds(0.5f);
        fxLeftTilt_1.enabled = false;
        yield return null;
    }
}
