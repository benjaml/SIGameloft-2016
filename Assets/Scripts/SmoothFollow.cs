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
        
        public float distance = 10.0f;
        // the height we want the camera to be above the target
        public float height = 5.0f;
        
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
        public float interiorHeightDive = 5.0f;
        private float interiorHeightForCalc;
        public float interiorDistance = 5.0f;
        public float interiorForward = 15.0f;
        public float exteriorHeight = 15.0f;
        public float exteriorDistance = 10.0f;
        public float exteriorForward = -5.0f;

        public float accelerationHeight = -75.0f;
        public float accelerationHeightDive = -40.0f;
        private float percentAccHeight;
        private float accelerationHeightForCalc;
        public float accelerationDistance = 20.0f;
        private float percentAccDist;

        public float baseFOV = 60.0f;
        public float accelerationFOV = 40.0f;

        private Camera mainCam;

        private PlayerMovement player;

        private float topAngle = 359.9f;
        private float exteriorAngle = 270.0f;
        private float downAngle = 180.0f;
        private float previousSpeed;

        // Use this for initialization
        void Awake()
        {
            //distance = Mathf.Abs(target.position.z - transform.position.z)/ lerpDampening;
            //height = Mathf.Abs(target.position.y - transform.position.y)/ lerpDampening;
            mainCam = Camera.main;
            player = target.gameObject.GetComponent<PlayerMovement>();
        }

        // Update is called once per frame
        void Update()
        {

            // Early out if we don't have a target
            if (!target)
                return;

            float yPos = transform.position.y;

            // Set the height of the camera
            //transform.position = Vector3.Lerp(transform.position, target.position+(distance * (-target.forward)) + (height * (target.up))+ offset, lerpDampening*Time.deltaTime);
            Vector3 newPos = Vector3.SmoothDamp(transform.position, target.position + (distance * (-target.forward)) + (height * (target.up)), ref smoothVel, smoothTime);
            //newPos.y = yPos;
            transform.position = newPos;
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

            if(Input.GetAxisRaw("R_YAxis_0") > 0.3f)
            {
                interiorHeightForCalc = interiorHeightDive;
                accelerationHeightForCalc = accelerationHeightDive;
            }
            else
            {
                interiorHeightForCalc = interiorHeight;
                accelerationHeightForCalc = accelerationHeight;
            }

            if(_zAngle <= topAngle && _zAngle >= downAngle)
            {

                percentAccDist = exteriorDistance * (1 + (accelerationDistance / 100));
                percentAccHeight = exteriorHeight * (1 + (accelerationHeight / 100));

                float _angleToChangeCamera = Mathf.Abs(_zAngle - exteriorAngle);

                if(interiorDistance > exteriorDistance)
                    distance = exteriorDistance + ((_angleToChangeCamera * (interiorDistance - exteriorDistance)) / 90);
                else
                    distance = exteriorDistance - ((_angleToChangeCamera * (exteriorDistance - interiorDistance)) / 90);

                if (interiorHeightForCalc > exteriorHeight)
                    height = exteriorHeight + ((_angleToChangeCamera * (interiorHeightForCalc - exteriorHeight)) / 90);
                else
                    height = exteriorHeight - ((_angleToChangeCamera * (exteriorHeight - interiorHeightForCalc)) / 90);

                if (interiorForward > exteriorForward)
                    forwardValue = exteriorForward + ((_angleToChangeCamera * (interiorForward - exteriorForward)) / 90);
                else
                    forwardValue = exteriorForward - ((_angleToChangeCamera * (exteriorForward - interiorForward)) / 90);
            }
            else
            {
                height = interiorHeightForCalc;
                distance = interiorDistance;
                forwardValue = interiorForward;
                percentAccDist = interiorDistance * (1 + (accelerationDistance / 100));
                percentAccHeight = interiorHeightForCalc * (1 + (accelerationHeightForCalc / 100));
            }

            float speed = player.getSpeed();

            if (speed < player.getBaseSpeed())
                speed = player.getBaseSpeed();

            if (speed > player.getMaxSpeed())
                speed = player.getMaxSpeed();

            speed = Mathf.Round(speed);

            float speedToAngle = (((speed - player.getMaxSpeed()) / -1) * 90) / (player.getMaxSpeed() - player.getBaseSpeed());

            if (distance > percentAccDist)
                distance = percentAccDist + ((speedToAngle * (distance - percentAccDist)) / 90);
            else
                distance = percentAccDist - ((speedToAngle * (percentAccDist - distance)) / 90);

            if (height > percentAccHeight)
                height = percentAccHeight + ((speedToAngle * (height - percentAccHeight)) / 90);
            else
                height = percentAccHeight - ((speedToAngle * (percentAccHeight - height)) / 90);

            if (baseFOV > accelerationFOV)
                mainCam.fieldOfView = accelerationFOV + ((speedToAngle * (baseFOV - accelerationFOV)) / 90);
            else
                mainCam.fieldOfView = accelerationFOV - ((speedToAngle * (accelerationFOV - baseFOV)) / 90);
            
        }
    }
}