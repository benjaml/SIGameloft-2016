using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class LDOrientation : MonoBehaviour
{
    // Use this for initialization
    // Update is called once per frame

    void Update()
    {
        Debug.DrawLine(transform.position, transform.position - transform.up, Color.red);
    }
    void OnGUI()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            if (hit.transform.tag == "floor")
            {
                transform.up = hit.normal;
            }
        }
        if (Application.isPlaying)
            Destroy(this);
    }
}