using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	

		//mover el avion
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 0.1f, 0.0f);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -0.1f, 0.0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (0.0f, 0.0f, -0.2f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (0.0f, 0.0f, 0.2f);
		}

		//Si el usuario presiona la tecla espacio
		if (Input.GetKeyDown (KeyCode.Space)) {

			GameObject clone = GameObject.Instantiate (Resources.Load ("Prefabs/Misil") as GameObject);
		}
		
	}
}
