using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour {
	
	[SerializeField]private EnemyBehaviour Enemybehaviour;
	private Slider _healthBar;
	private int _health;
	void Start () {
		_healthBar = GetComponent<Slider> ();
		Enemybehaviour = Enemybehaviour.GetComponent<EnemyBehaviour> ();
		_health = Enemybehaviour.getHealth;
		_healthBar.maxValue = _health;
	}
	
	void Update () {
		_health = Enemybehaviour.getHealth;
		_healthBar.value = _health;
	}
}
