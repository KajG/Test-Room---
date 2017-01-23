using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	private Vector3 movement;
	private float rotationTimer = 1; 
	[SerializeField]private float timerSet;
	private int randomRotation;
	[SerializeField]private float speed;
	void Update () {
		rotationTimer -= Time.fixedDeltaTime;
		this.transform.position += transform.up * Time.fixedDeltaTime * speed;
		if (rotationTimer <= 0) {
			movement = new Vector3 (0,0,Random.Range (0, 360));
			transform.eulerAngles = movement;
			rotationTimer = 1;
		}
	}
}
