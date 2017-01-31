using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : MonoBehaviour {
	[SerializeField] private int _health;
	[SerializeField] private BulletMovement bullet;
	public int getHealth{get{return _health;}set{_health = value;}}
	public TextMesh damageText;
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == ("bullet")) {
			bullet = other.gameObject.GetComponent<BulletMovement> ();
			_health -= bullet.getDamage;
			Destroy (other.gameObject);
			Instantiate (damageText, new Vector2(Random.Range(transform.position.x, transform.position.x - 1f), Random.Range(transform.position.y + 1, transform.position.y + 2)), Quaternion.identity);
			damageText.text = ("-" + bullet.getDamage);
		} 
	}
	void Update(){
		if (_health <= 0) {
			Destroy (gameObject);
		}
	}
}