﻿using UnityEngine;
using System.Collections;

public class port_controler : MonoBehaviour {

	public Material mat_selected;
	public Material standard;
	public bool selected;
	public Renderer rend;
	portGroup_controler parent;

	// Use this for initialization
	void Start () {
		 rend = gameObject.GetComponent<Renderer>();
		 parent = transform.parent.GetComponent<portGroup_controler>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		parent.selectionHandler (gameObject);
	}
}
