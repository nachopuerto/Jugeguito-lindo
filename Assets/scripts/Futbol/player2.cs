using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {
    Rigidbody2D rb; // decimos que vamos a utilizar un rigid body y lo nombramos


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>(); // con esto llamamos al rigid body del objeto en el que meto el script

	}
	
	// Update is called once per frame
	void Update () {
		// seleccionamos la tecla que queremos
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (0, 10); // aqui decimos que al pulsar la tecla, la velocidad del objeto es 0 en el eje x y 10 en el eje y
		}
	
		if (Input.GetKey (KeyCode.DownArrow)) {
			rb.velocity = new Vector2 (0, -10); 
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (-10, 0); 
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (10, 0); 
		}

		//------------------------------ GETKEYUP ------------------------------------------

		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (0,0); 
		}

		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			rb.velocity = new Vector2 (0,0); 
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (0, 0); 
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (0, 0); 
		}
	}
}
