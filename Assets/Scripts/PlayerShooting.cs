using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	[SerializeField]private float destroyTimer;
	[SerializeField]private UpgradeController UpgradeController;
	[SerializeField]private List<Transform> muzzleList = new List<Transform> ();
	private MouseLook MouseLook;
	public GameObject bullet;
	private float _angle;
	private int upgradeInt;

	void Start () {
		UpgradeController = UpgradeController.GetComponent<UpgradeController>();
		MouseLook = GetComponent<MouseLook>();
	}
	
	void Update () {
		_angle = MouseLook.getAngle;
		upgradeInt = UpgradeController.getUpgradeInt;
		if (Input.GetMouseButton(0)) {
			Shoot(upgradeInt);
		}
	}
	void Shoot(int number){
		switch (number) {
		case 0:
			Destroy (Instantiate (bullet,muzzleList[0].position, Quaternion.AngleAxis (_angle, Vector3.forward)), destroyTimer);
			break;
		case 1:
			print ("dsa");
			for (int i = 1; i > muzzleList.Count; i++) {
				print (muzzleList [i]);
				Destroy (Instantiate (bullet, muzzleList [i].position, Quaternion.AngleAxis (_angle, Vector3.forward)), destroyTimer);
			}
			break;
		case 2:
			for (int i = 0; i > muzzleList.Count; i++) {
				Destroy (Instantiate (bullet, muzzleList [i].position, Quaternion.AngleAxis (_angle, Vector3.forward)), destroyTimer);
			}
			break;
		}
	}
}
