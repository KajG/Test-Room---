using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour {
	public MouseLook Mouselook;
	[SerializeField]private int upgradeInt;
	[SerializeField]private PlayerShooting PlayerShooting;
	[SerializeField]private GameObject _spawnPlace;
	public Transform[] _muzzles;
	public int getUpgradeInt{get{return upgradeInt;}set{upgradeInt = value;}}
	void Start () {
		PlayerShooting = PlayerShooting.GetComponent<PlayerShooting> ();
		Mouselook = Mouselook.GetComponent<MouseLook> ();
		upgradeInt = Mouselook.getBulletAmount;
		_muzzles = PlayerShooting._getPlatform.GetComponentsInChildren<Transform> ();
		PlayerShooting.getMuzzleList.Add (_muzzles[0 + 2]);
	}
	//met upgradeint kan je zien op welke upgrade je nu zit, dus 0 == de eerste upgrade en 2 == de upgrade met 3 schoten
	//muzzlelist zorgt ervoor dat in de array obj alle muzzle's zitten, en dat ik met muzzle list de gene die ik wil gebruiken in die array worden gestopt
	public void OnClick(int number){
		upgradeInt = number;
		switch (upgradeInt) {
		case 0:
			PlayerShooting.getMuzzleList.Clear ();
			PlayerShooting.getMuzzleList.Add (_muzzles[2]); //de eerste 2 in de index zijn de platform en de ugprade dus die skip ik
			break;
		case 1:
			PlayerShooting.getMuzzleList.Clear ();
			PlayerShooting.getMuzzleList.Add (_muzzles[3]);	
			PlayerShooting.getMuzzleList.Add (_muzzles[4]);
			break;
		case 2:
			PlayerShooting.getMuzzleList.Clear ();
			for (int i = 0; i < 3; i++) {
				PlayerShooting.getMuzzleList.Add (_muzzles[i + 2]);
			}
			break;
		default:
			break;
		}
	}
}
