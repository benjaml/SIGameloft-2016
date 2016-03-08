using UnityEngine;
using System.Collections;
using ParticlePlayground;

public class PlayerBlocCollision : MonoBehaviour {

    public PlaygroundParticlesC fxBlocCollision_1;
    public PlaygroundParticlesC fxBlocCollision_2;
    public PlaygroundParticlesC fxBlocCollision_3;

    // Use this for initialization
    void Start () {
        fxBlocCollision_1.enabled = false;
        fxBlocCollision_2.enabled = false;
        fxBlocCollision_3.enabled = false;
    }
	
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "obstacleAir" || col.gameObject.tag == "obstacleFloor")
        {
            StartCoroutine(fxBlocCollision());
        }
    }

    IEnumerator fxBlocCollision()
    {
        fxBlocCollision_1.enabled = true;
        fxBlocCollision_2.enabled = true;
        fxBlocCollision_3.enabled = true;
        yield return new WaitForSeconds(0.4f);
        fxBlocCollision_1.emit = false;
        fxBlocCollision_2.emit = false;
        fxBlocCollision_3.emit = false;
        yield return null;
    }
}
