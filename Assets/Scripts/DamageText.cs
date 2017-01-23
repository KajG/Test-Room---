using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText : MonoBehaviour {

	private TextMesh text;
	private float textAlpha;

	void Start(){
		text = GetComponent<TextMesh> ();
	}

	[SerializeField] private float speed;
	private Vector3 movement;
	void Update () {
		movement = new Vector3 (0, speed, 0);
		this.transform.position += movement;
		textAlpha = text.color.a;
		textAlpha -= speed;
		text.color = new Color(text.color.r, text.color.g, text.color.b, textAlpha);
		if (textAlpha <= 0) {
			Destroy (gameObject);
		}
	}
}
