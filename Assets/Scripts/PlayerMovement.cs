using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	[SerializeField] private FetchInput input;
	[SerializeField] private float speed;
	[SerializeField] private int _health;
	public int getPlayerHealth{get{return _health;}set {_health = value;}}
	private Vector2 position;
	private Vector2 movement;

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
