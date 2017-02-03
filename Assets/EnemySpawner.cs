using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] private GameObject _enemy;
	[SerializeField] private float _timer;
	[SerializeField] private float _maxTimer;
	void Update () {
		_timer -= Time.fixedDeltaTime;
		if (_timer <= 0) {
			_timer = _maxTimer;
			Instantiate (_enemy, transform.position, Quaternion.identity);
		}
	}
}
