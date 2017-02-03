using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	[SerializeField] protected int _health;
	[SerializeField] protected BulletMovement bullet;
	[SerializeField] protected PointBehaviour PointBehaviour;
	[SerializeField] protected int _pointAmount;
	[SerializeField] protected int _randomAmountRange;
	public int getHealth{get{return _health;}set{_health = value;}}
	public TextMesh damageText;
	virtual public void Start(){
		PointBehaviour = GameObject.FindObjectOfType<PointBehaviour>();
	}
	virtual public void Update () {
		if (_health <= 0) {
			PointBehaviour.GetPoints (_pointAmount);
			Destroy (gameObject);
		}
	}
	virtual public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == ("bullet")) {
			bullet = other.gameObject.GetComponent<BulletMovement> ();
			_health -= bullet.getDamage;
			Destroy (other.gameObject);
			Instantiate (damageText, new Vector2(Random.Range(transform.position.x, transform.position.x - 1f), Random.Range(transform.position.y + 1, transform.position.y + 2)), Quaternion.identity);
			damageText.text = ("-" + bullet.getDamage);
		} 
	}
}
