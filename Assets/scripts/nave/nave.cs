using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour {
	public float fuerza = 10f;
	public float rotacion = 0.5f;

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			rb.AddForce (transform.up * fuerza);
		}		

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddTorque (rotacion);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddTorque (-rotacion);
		
		}
	}
}
