using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour {

	[SerializeField] private Image _menu;
	[SerializeField] private Button _resume;
	[SerializeField] private Button _quit;
	void Start(){
		_resume.enabled = false;
		_quit.enabled = false;
		_menu.enabled = false;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Time.timeScale = 0;
			_resume.enabled = true;
			_quit.enabled = true;
			_menu.enabled = true;
			if (_menu.enabled) {
				Time.timeScale = 1;
				_resume.enabled = false;
				_quit.enabled = false;
				_menu.enabled = false;
			}
		}
	}
	public void Quit(){
		Application.Quit ();
	}
	public void Resume(){
		Time.timeScale = 1;
		_resume.enabled = false;
		_quit.enabled = false;
		_menu.enabled = false;
	}
}
