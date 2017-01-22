using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCollision : MonoBehaviour {
	[SerializeField] private int _health;
	[SerializeField] private BulletMovement bullet;
	public TextMesh damageText;
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == ("bullet")) {
			bullet = other.gameObject.GetComponent<BulletMovement> ();
			_health -= bullet.getDamage;
			Destroy (other.gameObject);
			Instantiate (damageText, new Vector2(transform.position.x - 0.5f, transform.position.y + 2), Quaternion.identity);
			damageText.text = ("-" + bullet.getDamage);
		} 
	}
}