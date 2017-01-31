using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explota : MonoBehaviour {
	public GameObject explosion;
	public GameObject plataforma;
	public Animator panel_animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		panel_animator.SetBool ("visible", true);
		Instantiate (explosion,transform.position,transform.rotation);
		Destroy (plataforma); 
		Destroy (gameObject);

	}
}
