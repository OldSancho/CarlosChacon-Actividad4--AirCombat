using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileFalling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Mover hacia adelante
		this.transform.Translate(0.0f, 0.0f, 0.5f);
		
	}
	void OnCollisionEnter(Collision collision) {
		//Eliminamos el piso
		Destroy (collision.collider.gameObject);
	}
}
