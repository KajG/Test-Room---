using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour {
	public Transform playerPos;
	void Update () {
		this.transform.position =  new Vector3(playerPos.position.x, playerPos.position.y, -10);
	}
}
