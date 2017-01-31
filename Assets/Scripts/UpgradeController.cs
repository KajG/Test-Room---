using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour {
	public MouseLook Mouselook;
	private GameObject _obj;
	[SerializeField]private int upgradeInt;
	[SerializeField]private GameObject _spawnPlace;
	[SerializeField]private List<GameObject> _upgrades = new List<GameObject>();
	public int getUpgradeInt{get{return upgradeInt;}set{upgradeInt = value;}}
	void Start () {
		Mouselook = Mouselook.GetComponent<MouseLook> ();
		upgradeInt = Mouselook.getBulletAmount;
	}
	public void OnClick(int number){
		upgradeInt = number;
		switch (upgradeInt) {
		case 0:
			Destroy (_obj);
			SpawnUpgrade (0);
			break;
		case 1:
			Destroy (_obj);
			SpawnUpgrade (1);
			break;
		case 2:
			Destroy (_obj);
			SpawnUpgrade (2);
			break;
		default:
			break;
		}
	}
	void SpawnUpgrade(int number){
		upgradeInt = number;
		_obj = Instantiate (_upgrades [upgradeInt], _spawnPlace.transform.position, _spawnPlace.transform.rotation);
		_obj.transform.SetParent (_spawnPlace.transform);
		Mouselook.getBulletAmount = upgradeInt;
	}
}
