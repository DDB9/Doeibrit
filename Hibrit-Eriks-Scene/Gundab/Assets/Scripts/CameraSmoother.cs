using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoother : MonoBehaviour {

	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	public bool lookAt = false;

	void LateUpdate()
	{
		Vector3 targetPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
		transform.position = smoothedPosition;

		if (lookAt == true) transform.LookAt(target);
		
		
	}
}
