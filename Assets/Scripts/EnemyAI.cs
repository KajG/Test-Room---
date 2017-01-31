using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	private Vector3 movement;
	private float rotationTimer = 1; 
	private int randomRotation;
	[SerializeField]private float _timerSet;
	[SerializeField]private float _speed;
	[SerializeField]private float _degrees;
	private float timer = 1;
	private float x;
	private float y;
	void Update () {
		movement = new Vector3 (0,0,x);
		rotationTimer -= Time.fixedDeltaTime;
		this.transform.position += transform.up * Time.fixedDeltaTime * _speed;
		if (rotationTimer <= 0) {
			x = Random.Range (this.transform.eulerAngles.z - _degrees, this.transform.eulerAngles.z + _degrees);
			y = Mathf.Lerp (this.transform.eulerAngles.z, x, _timerSet);
			transform.eulerAngles = movement;
			rotationTimer = _timerSet;
		}
	}
}
