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

        public float smoothTime = 0.8f;
        private Vector3 smoothVel;
        private Vector3 smoothVel2;
        private float smoothVelRot;

        public float rightnessFactor = 4.0f;
        private float rightness;
        public float interiorHeight = 2.0f;
        public float interiorHeightDive = 5.0f;
        private float interiorHeightForCalc;
        public float interiorDistance = 5.0f;
        public float interiorForward = 15.0f;
        public float exteriorHeight = 15.0f;
        public float exteriorDistance = 10.0f;
        public float exteriorForward = -5.0f;

        [Header("Valeur Acceleration")]
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

        private float realTopAngle = 0.0f;
        private float topAngle = 359.9f;
        private float exteriorAngle = 270.0f;
        private float interiorAngle = 90.0f;
        private float downAngle = 180.0f;

        [Header("Fresque Camera")]
        public float fresqueDistance;
        public float fresqueHeight;
        public float fresqueForwardPosition;
        public float fresqueLookForward;
        public float smoothTimeCinematic;

        public bool isFresco = false;

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
                if (Input.GetAxisRaw("Horizontal") > 0.3)
                    rightness = rightnessFactor;
                else if (Input.GetAxisRaw("Horizontal") < -0.3)
                    rightness = -1.0f * rightnessFactor;
                else
                    rightness = 0.0f;

                // Set the height of the camera
                //transform.position = Vector3.Lerp(transform.position, target.position+(distance * (-target.forward)) + (height * (target.up))+ offset, lerpDampening*Time.deltaTime);
                transform.position = Vector3.SmoothDamp(transform.position,
                    target.position + (distance*(-target.forward)) + (height*(target.up) + (rightness * target.right)), ref smoothVel, smoothTime);
                Quaternion targetRotation;
                Vector3 lookPoint = Vector3.SmoothDamp(transform.position, target.position + forwardValue*target.forward,
                    ref smoothVel2, smoothTime);

                targetRotation = Quaternion.FromToRotation(transform.up, target.up);
                targetRotation *= Quaternion.FromToRotation(transform.forward, (lookPoint - transform.position));
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation*transform.rotation, smoothTime);
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

            if (Input.GetAxisRaw("R_YAxis_0") > 0.3f && (_zAngle >= realTopAngle && _zAngle <= downAngle))
            {
                float _angleToDiveCamera = Mathf.Abs(interiorAngle - _zAngle);

                if (interiorHeight > interiorHeightDive)
                    interiorHeightForCalc = interiorHeightDive + ((_angleToDiveCamera * (interiorHeight - interiorHeightDive)) / 90);
                else
                    interiorHeightForCalc = interiorHeightDive - ((_angleToDiveCamera * (interiorHeightDive - interiorHeight)) / 90);

                if (accelerationHeight > accelerationHeightDive)
                    accelerationHeightForCalc = accelerationHeightDive + ((_angleToDiveCamera * (accelerationHeight - accelerationHeightDive)) / 90);
                else
                    accelerationHeightForCalc = accelerationHeightDive - ((_angleToDiveCamera * (accelerationHeightDive - accelerationHeight)) / 90);
            }
            else
            {
                interiorHeightForCalc = interiorHeight;
                accelerationHeightForCalc = accelerationHeight;
            }

            if (_zAngle <= topAngle && _zAngle >= downAngle)
            {
                percentAccDist = exteriorDistance * (1 + (accelerationDistance / 100));
                percentAccHeight = exteriorHeight * (1 + (accelerationHeight / 100));

                float _angleToChangeCamera = Mathf.Abs(_zAngle - exteriorAngle);

                if (interiorDistance > exteriorDistance)
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

        public void fresqueMode()
        {
            isFresco = true;
        }

        public void gameMode()
        {
            isFresco = false;
        }
    }
}