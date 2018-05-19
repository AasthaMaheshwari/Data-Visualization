using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameDisplay3 : MonoBehaviour {

	public Text display_Filename_colors;

	void Start () {

		display_Filename_colors = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();


	}


	void OnMouseOver()
	{

		display_Filename_colors.text = "Colors";
	}

	// Update is called once per frame
	void OnMouseExit(){


		display_Filename_colors.text = " ";

	}
}