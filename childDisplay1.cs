using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class childDisplay1 : MonoBehaviour {

	public Text display_Filename_vs;

	void Start () {



		display_Filename_vs = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();




	}


	void OnMouseOver()
	{
		
		display_Filename_vs.text = "Images";

	}


	void OnMouseExit(){


		display_Filename_vs.text = " ";
	

	}
}

