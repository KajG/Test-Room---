using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {

	public Slider healthbar;
	public PlayerMovement Playermovement;
	private BulletMovement bullet;
	public TextMesh damageText;
	private int _health;

	void Start () {
		Playermovement = Playermovement.GetComponent<PlayerMovement> ();
		_health = Playermovement.getPlayerHealth;
	}
	
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "bullet") {
			print ("asds");
			bullet = other.gameObject.GetComponent<BulletMovement> ();
			_health -= bullet.getDamage;
			Destroy (other.gameObject);
			Instantiate (damageText, new Vector2(transform.position.x - 0.5f, transform.position.y + 2), Quaternion.identity);
			damageText.text = ("-" + bullet.getDamage);
			healthbar.value = _health;
		}
	}
}
