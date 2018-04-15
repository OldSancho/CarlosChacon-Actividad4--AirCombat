using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {


	public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.up * Time.deltaTime * speed);
		transform.Translate(new Vector3(0f,0f,-0.8f)* Time.deltaTime * 5f);
		
	}
}
