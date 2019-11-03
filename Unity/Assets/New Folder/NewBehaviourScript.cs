using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rojo : MonoBehaviour {

	public float velocidad = 100f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.A))
			transform.Translate (Vector2.left * velocidad * Time.deltaTime);

	}
}

