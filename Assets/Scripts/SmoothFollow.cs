using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class SmoothFollow : MonoBehaviour
    {

        // The target we are following
        [SerializeField]
        private Transform target;
        // The distance in the x-z plane to the target
        /*[SerializeField]
        private float distanceInterne = 10.0f;
        // the height we want the camera to be above the target
        [SerializeField]
        private float heightInterne = 5.0f;

        [SerializeField]
        private float distanceExterne = 10.0f;
        // the height we want the camera to be above the target
        [SerializeField]
        private float heightExterne = 5.0f;*/

        [SerializeField]
        private float distance = 10.0f;
        // the height we want the camera to be above the target
        [SerializeField]
        private float height = 5.0f;

        [SerializeField]
        private float rotationDamping;
        [SerializeField]
        private float heightDamping;

        [SerializeField]
        private float lerpDampening = 0.1f;

        public float forwardValue;

        public Vector3 offset;

        public float smoothTime = 0.3f;
        Vector3 smoothVel;
        Vector3 smoothVel2;
        float smoothVelRot;
        public float interiorHeight = 3.0f;
        public float interiorDistance = 5.0f;
        public float exteriorHeight = 10.0f;
        public float exteriorDistance = 1.0f;

        // Use this for initialization
        void Awake()
        {
            //distance = Mathf.Abs(target.position.z - transform.position.z)/ lerpDampening;
            //height = Mathf.Abs(target.position.y - transform.position.y)/ lerpDampening;
        }

        // Update is called once per frame
        void Update()
        {

            // Early out if we don't have a target
            if (!target)
                return;

            // Set the height of the camera
            //transform.position = Vector3.Lerp(transform.position, target.position+(distance * (-target.forward)) + (height * (target.up))+ offset, lerpDampening*Time.deltaTime);
            transform.position = Vector3.SmoothDamp(transform.position, target.position + (distance * (-target.forward)) + (height * (target.up)) + offset, ref smoothVel, smoothTime);
            //transform.position += offset;

            //transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref smoothVel, smoothTime);

            //cimetic camera
            //transform.position = Vector3.Lerp(target.position, (distance * (-target.forward)) + (height * (target.up)) ,lerpDampening);

            //LookAt correct but Shaky
            //Vector3 _vForward = target.position - transform.position;
            //Vector3 _vUp = (target.position + target.up) - (transform.position + transform.up);

            //Quaternion _rot = Quaternion.LookRotation(_vForward, _vUp);

            //FromToRotation Very Smooth but does not look the player
            /*Quaternion _forward = Quaternion.FromToRotation(transform.position, target.position - transform.position);
            Quaternion _up = Quaternion.FromToRotation(transform.position - transform.up, target.position - target.up);
        
            Quaternion _newRot = _up * _forward;
            */

            //Apply rotations to smooth the movement of cam
            //transform.forward = target.forward;
            //transform.rotation = Quaternion.FromToRotation(transform.up, target.up);

            //transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation*Quaternion.FromToRotation(transform.forward,(target.position-transform.position).normalized),0.1f);
            Quaternion targetRotation;
            Vector3 lookPoint = Vector3.SmoothDamp(transform.position, target.position + forwardValue * target.forward, ref smoothVel2, smoothTime);

            /*Quaternion targetRotation = Quaternion.LookRotation(lookPoint - transform.position, transform.position + target.up);
            //targetRotation *= Quaternion.FromToRotation(transform.up, target.up); 

            Debug.DrawLine(transform.position, transform.position + target.up * 10, Color.red);
            Debug.DrawLine(target.position, target.position + target.up * 10, Color.blue);

            //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.1f);
            */
            
            targetRotation = Quaternion.FromToRotation(transform.up, target.up);
            targetRotation *= Quaternion.FromToRotation(transform.forward, (lookPoint-transform.position));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation * transform.rotation, 0.1f);
            
            //transform.eulerAngles = Vector3.SmoothDamp(transform.eulerAngles, target.eulerAngles, ref smoothVelRot, smoothTime);

            // Always look at the target, but is shaky
            //transform.LookAt(target, target.up);
        }
    }
}