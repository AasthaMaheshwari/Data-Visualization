using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parent1_name : MonoBehaviour {
	
	public Text display_Filename_CB;
	/*public Text display_Filename_vs;
	public Text display_Filename_images;
	public Text display_Filename_hooksMAC;
	public Text display_Filename_API;
	public Text display_Filename_Colors;
	public Text display_Filename_Hooks;
	public Text display_Filename_Css;
	public Text display_Filename_Lib;*/


	// Use this for initialization
	void Start () {
		

		display_Filename_CB = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();
		//display_Filename_vs = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();
		//display_Filename_images = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();


		//display_Filename = transform.localScale.Scale ();


	}


	void OnMouseOver()
	{
		display_Filename_CB.text = "CBSoftware HTML: CSS Scripts";
		//display_Filename_vs.text = ".vs";
		//display_Filename_images.text = "Images";
	}

	// Update is called once per frame
	void OnMouseExit(){

		display_Filename_CB.text = " ";
		//display_Filename_vs.text = " ";
		//display_Filename_vs.text = " ";

	}
}
