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
        
        private float distance = 10.0f;
        // the height we want the camera to be above the target
        private float height = 5.0f;
        
        private float rotationDamping;
        private float heightDamping;
        private float lerpDampening = 0.1f;

        private float forwardValue;

        public Vector3 offset;

        private float smoothTime = 0.3f;
        private Vector3 smoothVel;
        private Vector3 smoothVel2;
        private float smoothVelRot;

        public float interiorHeight = 2.0f;
        public float interiorDistance = 5.0f;
        public float interiorForward = 15.0f;
        public float exteriorHeight = 15.0f;
        public float exteriorDistance = 10.0f;
        public float exteriorForward = -5.0f;

        public float accelerationHeight = 5.0f;
        public float accelerationDistance = 20.0f;
        private float accelerationAngle = 90.0f;

        private float topAngle = 359.9f;
        private float exteriorAngle = 270.0f;
        private float downAngle = 180.0f;

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
            transform.position = Vector3.SmoothDamp(transform.position, target.position + (distance * (-target.forward)) + (height * (target.up)), ref smoothVel, smoothTime);
            //transform.position = target.position + (distance * (-target.forward)) + (height * (target.up));
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

            float _zAngle = transform.eulerAngles.z;

            if (_zAngle == 0)
                _zAngle = 360;

            if(_zAngle <= topAngle && _zAngle >= downAngle)
            {
                float _angleToChangeCamera = Mathf.Abs(_zAngle - exteriorAngle);

                if(interiorDistance > exteriorDistance)
                    distance = exteriorDistance + ((_angleToChangeCamera * (interiorDistance - exteriorDistance)) / 90);
                else
                    distance = exteriorDistance - ((_angleToChangeCamera * (exteriorDistance - interiorDistance)) / 90);

                if (interiorHeight > exteriorHeight)
                    height = exteriorHeight + ((_angleToChangeCamera * (interiorHeight - exteriorHeight)) / 90);
                else
                    height = exteriorHeight - ((_angleToChangeCamera * (exteriorHeight - interiorHeight)) / 90);

                if (interiorForward > exteriorForward)
                    forwardValue = exteriorForward + ((_angleToChangeCamera * (interiorForward - exteriorForward)) / 90);
                else
                    forwardValue = exteriorForward - ((_angleToChangeCamera * (exteriorForward - interiorForward)) / 90);
            }
            else
            {
                height = interiorHeight;
                distance = interiorDistance;
                forwardValue = interiorForward;
            }

            float _yStick = Input.GetAxisRaw("Vertical");

            if ((_yStick > 0.3) && accelerationAngle > 0.0f)
            {
                distance = (distance + accelerationDistance) - ((accelerationAngle * accelerationDistance) / 90);
                height = (height / accelerationHeight) + ((accelerationAngle * (height - (height / accelerationHeight))) / 90);
                accelerationAngle -= Time.deltaTime;
            }
        }
    }
}