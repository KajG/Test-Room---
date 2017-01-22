﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public GameObject bullet;
	private float angle;
	public float getAngle{get{return angle;}set {angle = value;}}
	[SerializeField]private float destroyTimer;
	[SerializeField]private Transform muzzlePos;
	[SerializeField]private float shootTimerLimit;
	private float shootTimer;
	public Transform look;
	private Vector2 mousePos;

	void Start () {
		look = GetComponent<Transform> ();
	}
	
	void Update () {
		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
		lookPos = lookPos - transform.position;
		angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		shootTimer -= Time.fixedDeltaTime;
		if (Input.GetMouseButton (0)) {
			Shoot ();
		}
	}

	void Shoot(){
		if (shootTimer <= 0) {
			Destroy (Instantiate (bullet, muzzlePos.position, Quaternion.AngleAxis (angle, Vector3.forward)), destroyTimer);
			bullet.gameObject.tag = "bullet";
			shootTimer = shootTimerLimit;
		}
	}
}
