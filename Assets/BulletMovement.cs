using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
	[SerializeField] private int _damage;
	public int getDamage{get{return _damage;}set {_damage = value;}}
	[SerializeField] private float speed;
	void Update () {
		transform.position += transform.right * Time.fixedDeltaTime * speed;
	}
}
