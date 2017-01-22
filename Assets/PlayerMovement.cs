using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	[SerializeField] private FetchInput input;
	[SerializeField] private float speed;
	private Vector2 position;
	private Vector2 movement;

	void Start () {
		
	}
	
	void Update () {
		position = this.transform.position;
		if (input.getUpKey) {
			position += new Vector2 (0, speed / 50);
		} 
		if (input.getLeftKey) {
			position += new Vector2 ((speed / 50) * -1, 0);
		}
		if (input.getRightKey) {
			position += new Vector2 (speed / 50, 0);
		}
		if (input.getDownKey) {
			position += new Vector2 (0, (speed / 50) * -1);
		}
		this.transform.position = position;
	}
}
