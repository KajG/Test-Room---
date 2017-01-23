using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public GameObject bullet;
	private float angle;
	public float getAngle{get{return angle;}set {angle = value;}}
	[SerializeField]private float destroyTimer;
	[SerializeField]private List<Transform> muzzlePos = new List<Transform>();
	[SerializeField]private float shootTimerLimit;
	[SerializeField]private int upgrade;
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
			Shoot (upgrade);
		}
	}

	void Shoot(int amount){
		if (shootTimer <= 0) {
			shootTimer = shootTimerLimit;
			for (int i = 0; i < amount; i++) {
				Destroy (Instantiate (bullet, muzzlePos [i].position, Quaternion.AngleAxis (angle, Vector3.forward)), destroyTimer);
			}
			bullet.gameObject.tag = "bullet";
		}
	}
}
