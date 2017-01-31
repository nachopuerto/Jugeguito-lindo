﻿using UnityEngine;
using System.Collections;

public class Movimiento_plataforma1 : MonoBehaviour {
	public GameObject plataforma;
	public Transform Inicio;
	public Transform Fin;
	private Vector3 Destino;
	public float velocidad = 10f;
	// Use this for initialization
	void Start () {
		Destino = Fin.position;
	}
	
	// Update is called once per frame
	void Update () {
		plataforma.transform.position = Vector3.MoveTowards (plataforma.transform.position, Destino, velocidad * Time.deltaTime);

		if (plataforma.transform.position == Fin.position) {
			Destino = Inicio.position;
			plataforma.transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (plataforma.transform.position == Inicio.position) {
			Destino = Fin.position;
			plataforma.transform.localScale = new Vector3 (1, 1, 1);
		}
	}
}
