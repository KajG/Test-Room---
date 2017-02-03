using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointBehaviour : MonoBehaviour {

	[SerializeField]private Text _pointText;
	[SerializeField]private int _points;
	[SerializeField]private string text;
	public int _getPoints {get{return _points;}set{_points = value;}}
	void Update () {
		_pointText.text = (text + _points + "$");
	}
	public void GetPoints(int amount){
		_points += amount;
	}
}
