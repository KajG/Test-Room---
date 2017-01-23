using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour {
	public MouseLook Mouselook;
	private int upgradeInt;
	void Start () {
		Mouselook = Mouselook.GetComponent<MouseLook> ();
		upgradeInt = Mouselook.getBulletAmount;
	}
	public void OnClick(int number){
		upgradeInt = number;
		Mouselook.getBulletAmount = upgradeInt;
	}
}
