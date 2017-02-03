using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotation : MonoBehaviour {

	private Quaternion _rotation;
	void Start () {
		_rotation = transform.rotation;
	}
	
	void FixedUpdate () {
		transform.rotation = _rotation;
	}
}
