using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : Enemy {
	public override void Start(){
		_pointAmount = Random.Range (_pointAmount - _randomAmountRange, _pointAmount);
		PointBehaviour = GameObject.FindObjectOfType<PointBehaviour>();
	}

}