﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cbName11: MonoBehaviour {

	public Text display_Filename_log;

	void Start () {

		display_Filename_log = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();


	}


	void OnMouseOver()
	{

		display_Filename_log.text = "bookinformation.html";
	}

	// Update is called once per frame
	void OnMouseExit(){


		display_Filename_log.text = " ";

	}
}