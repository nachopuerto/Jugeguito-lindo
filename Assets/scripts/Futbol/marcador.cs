using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // tenemos que añadir esto para utilizar UI
using UnityEngine.SceneManagement;

public class marcador : MonoBehaviour {
	public Text texto_marcador;
	int goles = 0;

	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {
		if (goles >= 5) { 
			SceneManager.LoadScene ("Nave");  
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.transform.name == "balon"){ // si un objeto llamado balon entra en la porteria...
			goles += 1; // goles +1
			texto_marcador.text = goles + "";
		}
	}
}
