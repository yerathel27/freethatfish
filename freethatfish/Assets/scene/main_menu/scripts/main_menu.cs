﻿using UnityEngine;
using System.Collections;

public class main_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void goToEditor(){
		Application.LoadLevel ("editor_v01");
	}
}
