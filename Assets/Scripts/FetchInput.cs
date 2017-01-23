using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchInput : MonoBehaviour {

	private bool upKey;
	private bool leftKey;
	private bool rightKey;
	private bool downKey;
	public bool getUpKey{get {return upKey;}}
	public bool getLeftKey{get{return leftKey;}}
	public bool getRightKey{get{return rightKey;}}
	public bool getDownKey{get{return downKey;}}

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			upKey = true;
		} else {
			upKey = false;
		}
		if (Input.GetKey (KeyCode.A)) {
			leftKey = true;
		} else {
			leftKey = false;
		}
		if (Input.GetKey (KeyCode.D)) {
			rightKey = true;
		} else {
			rightKey = false;
		}
		if (Input.GetKey (KeyCode.S)) {
			downKey = true;
		} else {
			downKey = false;
		}
	}
}
