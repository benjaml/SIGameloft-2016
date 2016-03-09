using UnityEngine;
using System.Collections;
using ParticlePlayground;

public class CollectibleFx : MonoBehaviour {

    public PlaygroundParticlesC fxLotus_1;
    public PlaygroundParticlesC fxLotus_2;


    void Start () {
        fxLotus_1.enabled = false;
        fxLotus_2.enabled = false;
     
    }

    void Update ()
    {
        Debug.Log(fxLotus_1.emit);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            SoundManagerEvent.emit(SoundManagerType.Flower);
            SoundManagerEvent.emit(SoundManagerType.Talk);
            StartCoroutine(fxLotusEmission());
        }
    }

    IEnumerator fxLotusEmission()
    {
        fxLotus_1.enabled = true;
        fxLotus_2.enabled = true;
        yield return new WaitForSeconds(0.5f);
        fxLotus_1.emit = false;
        fxLotus_2.emit = false;
        yield return null;

    }
}
