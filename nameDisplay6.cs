﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameDisplay6 : MonoBehaviour {

	public Text display_Filename_MAC;

	void Start () {

		display_Filename_MAC = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();


	}


	void OnMouseOver()
	{

		display_Filename_MAC.text = "CSS";
	}

	// Update is called once per frame
	void OnMouseExit(){


		display_Filename_MAC.text = " ";

	}
}
