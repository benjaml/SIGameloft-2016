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
        public float interiorDistance = 5.0f;
        public float interiorForward = 15.0f;
        public float exteriorHeight = 15.0f;
        public float exteriorDistance = 10.0f;
        public float exteriorForward = -5.0f;

        public float accelerationHeight = -80.0f;
        private float percentAccHeight;
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

        [Header("Fresque Camera")]
        public float fresqueDistance;
        public float fresqueHeight;
        public float fresqueForwardPosition;
        public float fresqueLookForward;
        public float smoothTimeCinematic;

        public bool isFresco = true;

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

            if (!isFresco)
            {
                // Set the height of the camera
                //transform.position = Vector3.Lerp(transform.position, target.position+(distance * (-target.forward)) + (height * (target.up))+ offset, lerpDampening*Time.deltaTime);
                transform.position = Vector3.SmoothDamp(transform.position,
                    target.position + (distance*(-target.forward)) + (height*(target.up)), ref smoothVel, smoothTime);
                Quaternion targetRotation;
                Vector3 lookPoint = Vector3.SmoothDamp(transform.position, target.position + forwardValue*target.forward,
                    ref smoothVel2, smoothTime);

                targetRotation = Quaternion.FromToRotation(transform.up, target.up);
                targetRotation *= Quaternion.FromToRotation(transform.forward, (lookPoint - transform.position));
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation*transform.rotation, 0.1f);

            }
            else
            {
                transform.position = Vector3.SmoothDamp(transform.position,target.position + (fresqueDistance * (target.right)) + (fresqueHeight * (target.up)) + (fresqueForwardPosition * (target.forward)), ref smoothVel, smoothTimeCinematic);
                Quaternion targetRotation;
                Vector3 lookPoint = Vector3.SmoothDamp(transform.position, target.position + fresqueLookForward * target.forward,
                    ref smoothVel2, smoothTimeCinematic);

                targetRotation = Quaternion.FromToRotation(transform.up, target.up);
                targetRotation *= Quaternion.FromToRotation(transform.forward, (lookPoint - transform.position));
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation * transform.rotation, 0.1f);

            }
            

            float _zAngle = transform.eulerAngles.z;

            if (_zAngle == 0)
                _zAngle = 360;

            if(_zAngle <= topAngle && _zAngle >= downAngle)
            {

                percentAccDist = exteriorDistance * (1 + (accelerationDistance / 100));
                percentAccHeight = exteriorHeight * (1 + (accelerationHeight / 100));

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
                percentAccDist = interiorDistance * (1 + (accelerationDistance / 100));
                percentAccHeight = interiorHeight * (1 + (accelerationHeight / 100));
            }

            float speed = player.getSpeed();

            if (speed < player.getBaseSpeed())
                speed = player.getBaseSpeed();

            if (speed > player.getMaxSpeed())
                speed = player.getMaxSpeed();

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