using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour {
	[SerializeField] protected int _price;
	[SerializeField] protected Text _priceText;
	protected bool _isBought;
	protected Button _button;
	protected PointBehaviour PointBehaviour;
	virtual public void Start(){
		_button = GetComponent<Button> ();
		PointBehaviour = GameObject.FindObjectOfType<PointBehaviour> ();
	}
	virtual public void Update(){
		if (_isBought == false) {
			_priceText.text = ("Price: " + _price + "$"); 
			if (PointBehaviour._getPoints <= _price) {
				_button.interactable = false;
			} else {
				_button.interactable = true;
			}
		}
	}
	virtual public void OnClick(){
		PointBehaviour._getPoints -= _price;
		_isBought = true;
		_button.interactable = false;
		_priceText.text = ("*BOUGHT*");
	}
}
