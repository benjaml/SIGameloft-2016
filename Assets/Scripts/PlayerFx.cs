using UnityEngine;
using System.Collections;
using ParticlePlayground;

public class PlayerFx : MonoBehaviour {

    public PlaygroundParticlesC fxDiveFoam;

    //Right tilt
    public PlaygroundParticlesC fxRightTilt_1;
    public PlaygroundParticlesC fxRightTilt_2;

    //Left tilt
    public PlaygroundParticlesC fxLeftTilt_1;
    public PlaygroundParticlesC fxLeftTilt_2;

    private bool isGrounded;

    void Start()
    {         fxDiveFoam.enabled = false;
        fxLeftTilt_1.enabled = false;
        fxLeftTilt_2.enabled = false;
        fxRightTilt_1.enabled = false;
        fxRightTilt_2.enabled = false;
    }

    void Update ()
    {
        isGrounded = GetComponent<PlayerMovement>().isGrounded;

        if (Input.GetAxisRaw("R_YAxis_0") > 0 && isGrounded)
        {
            fxDiveFoam.enabled = true;
            fxDiveFoam.emit = true;
        }

        if (Input.GetAxisRaw("R_YAxis_0") < 0.1 && isGrounded)
        {
            StartCoroutine(fxDive());
        }
        if (Input.GetAxisRaw("R_YAxis_0") > 0 && isGrounded)
        {
            fxDiveFoam.enabled = true;
            fxDiveFoam.emit = true;
        }

        //Left tilt
        if (Input.GetAxisRaw("Horizontal") > 0.2f  && isGrounded)
        {
            fxRightTilt_1.enabled = true;
            fxRightTilt_1.emit = true;
            fxRightTilt_2.enabled = true;
            fxRightTilt_2.emit = true;
<<<<<<< HEAD



=======
>>>>>>> origin/CameraAndFixes
        }

        //Right tilt
        if (Input.GetAxisRaw("Horizontal") < -0.2f && isGrounded)
        {
            fxLeftTilt_1.enabled = true;
            fxLeftTilt_1.emit = true;
            fxLeftTilt_2.enabled = true;
            fxLeftTilt_2.emit = true;

           
        }

        if ((Input.GetAxisRaw("Horizontal") == 0  && isGrounded)|| !isGrounded)
        {

            StartCoroutine(fxTiltRight());
            StartCoroutine(fxTiltLeft());
        }


    }

    IEnumerator fxDive()
    {
        fxDiveFoam.emit = false;
        yield return new WaitForSeconds(0.5f);
        fxDiveFoam.enabled = false;
        yield return null;
    }

    IEnumerator fxTiltRight()
    {

        fxRightTilt_1.emit = false;
        fxRightTilt_2.emit = false;
        yield return new WaitForSeconds(0.5f);
        fxRightTilt_1.enabled = false;
        fxRightTilt_2.enabled = false;
        yield return null;
    }

    IEnumerator fxTiltLeft()
    {
        fxLeftTilt_1.emit = false;
        fxLeftTilt_2.emit = false;
        yield return new WaitForSeconds(0.5f);
        fxLeftTilt_1.enabled = false;
        fxLeftTilt_2.enabled = false;
        yield return null;
    }
}
