﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name5: MonoBehaviour {

	public Text display_Filename_log;

	void Start () {

		display_Filename_log = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();


	}


	void OnMouseOver()
	{

		display_Filename_log.text = "html15.png";
	}

	// Update is called once per frame
	void OnMouseExit(){


		display_Filename_log.text = " ";

	}
}
