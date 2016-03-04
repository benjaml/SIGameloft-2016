using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class SmoothFollow : MonoBehaviour
	{

		// The target we are following
		[SerializeField]
		private Transform target;
		// The distance in the x-z plane to the target
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

        public Vector3 offset;

        public float smoothTime;
        Vector3 smoothVel;

        // Use this for initialization
        void Start() { }

		// Update is called once per frame
		void Update()
		{
			// Early out if we don't have a target
			if (!target)
				return;

            // Set the height of the camera
            transform.position = Vector3.Lerp(target.position, target.position+(distance * (-target.forward)) + (height * (target.up)) ,lerpDampening);

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

            //Apply rotations to smooth the movement of cam
            transform.rotation = Quaternion.Slerp(transform.rotation, _newRot, 6.0f * Time.deltaTime);*/

            //transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation*Quaternion.FromToRotation(transform.forward,(target.position-transform.position).normalized),0.1f);

            Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.8f);

            // Always look at the target, but is shaky
            //transform.LookAt(target, target.up);
        }
    }
}