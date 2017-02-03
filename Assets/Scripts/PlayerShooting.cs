using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	[SerializeField]private float destroyTimer;
	[SerializeField]private UpgradeController UpgradeController;
	[SerializeField]private List<Transform> muzzleList = new List<Transform> ();
	[SerializeField]private GameObject _platform;
	[SerializeField]private float _maxTimer;
	private float _bulletTimer;
	public GameObject _getPlatform{get{return _platform;} set{_platform = value;}}
	public List<Transform> getMuzzleList{get{return muzzleList;} set {muzzleList = value;}}
	private MouseLook MouseLook;
	public GameObject bullet;
	private float _angle;
	private int upgradeInt;

	void Start () {
		UpgradeController = UpgradeController.GetComponent<UpgradeController>();
		MouseLook = GetComponent<MouseLook>();
	}
	
	void Update () {
		_bulletTimer -= Time.fixedDeltaTime;
		_angle = MouseLook.getAngle;
		upgradeInt = UpgradeController.getUpgradeInt;
		if (Input.GetMouseButton(0)) {
			Shoot();
		}
	}
	void Shoot(){
		if (_bulletTimer <= 0) {
			for (int i = 0; i < muzzleList.Count; i++) {
				Destroy (Instantiate (bullet, muzzleList [i].position, Quaternion.AngleAxis (MouseLook.getAngle, Vector3.forward)), destroyTimer);
				_bulletTimer = _maxTimer;
			}
		}
	}
}
