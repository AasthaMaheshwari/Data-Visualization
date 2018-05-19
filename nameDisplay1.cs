using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameDisplay1 : MonoBehaviour {

	public Text display_Filename_vs;

	void Start () {


		//display_Filename_CB = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();
		display_Filename_vs = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();
		//display_Filename_images = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();


		//display_Filename = transform.localScale.Scale ();


	}


	void OnMouseOver()
	{
		//display_Filename_CB.text = "CBSoftware HTML: CSS Scripts";
		display_Filename_vs.text = ".vs";
		//display_Filename_images.text = "Images";
	}

	// Update is called once per frame
	void OnMouseExit(){

		//display_Filename_CB.text = " ";
		display_Filename_vs.text = " ";
		//display_Filename_vs.text = " ";

	}
}
