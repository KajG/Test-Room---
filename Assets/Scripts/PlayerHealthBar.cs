using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {

	public Slider healthbar;
	public PlayerMovement Playermovement;
	private BulletMovement bullet;
	public TextMesh damageText;
	[SerializeField]private int _health;
	public int getHealth{get{return _health;}set{_health = value;}}
	void Start () {
		Playermovement = Playermovement.GetComponent<PlayerMovement> ();
		healthbar.value = _health;
	}
	void Update () {
		if (_health <= 0) {
			_health = 0;
		}
	}
	void OnTriggerEnter2D(Collider2D other){

	}
}
