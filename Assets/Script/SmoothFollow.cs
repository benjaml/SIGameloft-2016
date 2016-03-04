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

            transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref smoothVel, smoothTime);

            //cimetic camera
            //transform.position = Vector3.Lerp(target.position, (distance * (-target.forward)) + (height * (target.up)) ,lerpDampening);

            Vector3 _forward = (target.position + target.forward) - (transform.position + transform.forward);
            Vector3 _up = (target.position + target.up);

            Quaternion _newRot = Quaternion.LookRotation(_forward, -_up);

            transform.rotation = Quaternion.Lerp(transform.rotation, _newRot, lerpDampening);

            // Always look at the target
            //transform.LookAt(target, target.up);
		}
	}
}