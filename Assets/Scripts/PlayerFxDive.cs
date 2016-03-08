using UnityEngine;
using System.Collections;
using ParticlePlayground;

public class PlayerFxDive : MonoBehaviour {

    public PlaygroundParticlesC fxDiveFoam;
    private bool isGrounded;


    void Start ()
    {
        fxDiveFoam.enabled = false;
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

    }

    IEnumerator fxDive()
    {
        fxDiveFoam.emit = false;
        yield return new WaitForSeconds(0.5f);
        fxDiveFoam.enabled = false;
        yield return null;
    }
}
