using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxValue : MonoBehaviour {
	public PlayerHealthBar maxValue;
	private int maxHealth;
	private Slider slider;
	[SerializeField]private Text _healthText;
	void Start () {
		maxValue = maxValue.GetComponent<PlayerHealthBar> ();
		slider = GetComponent<Slider> ();
		slider.maxValue = maxValue.getHealth;
		_healthText = _healthText.GetComponent<Text> ();
		maxHealth = maxValue.getHealth;
	}
	void Update () {
		slider.value = maxValue.getHealth;
		_healthText.text = "Health: " + maxValue.getHealth + "/" + maxHealth;
	}
}
