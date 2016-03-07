using UnityEngine;
using System.Collections;

public class PlayerTilt : MonoBehaviour {

    public float tilt; //permet de pencher le gameobject
    GameObject characterVisual;
    float zPosition;
    public float smooth;

    // Use this for initialization
    void Start () {

        characterVisual = transform.GetChild(1).gameObject;
        zPosition = characterVisual.transform.localEulerAngles.z;
        characterVisual.transform.localEulerAngles = new Vector3(0, 0,  zPosition);

    }
	
	// Update is called once per frame
	void Update () {

        //Tilt

        //characterVisual.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, Input.GetAxisRaw("Horizontal") * -tilt);


        zPosition = Input.GetAxisRaw("Horizontal") * -tilt;
        //Debug.Log(zPosition);

        characterVisual.transform.localEulerAngles= new Vector3(0, 0, Mathf.Lerp(Mathf.Clamp((characterVisual.transform.localEulerAngles.z), -345,0), zPosition, Time.time * smooth));
        Debug.Log(characterVisual.transform.localEulerAngles);

    }
}
