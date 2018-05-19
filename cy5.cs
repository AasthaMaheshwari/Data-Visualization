using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cy5 : MonoBehaviour {

	public Text display_Filename_LIB;

	void Start () {

		display_Filename_LIB = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();


	}


	void OnMouseOver()
	{

		display_Filename_LIB.text = "PeerLibrary logo.png";
	}

	// Update is called once per frame
	void OnMouseExit(){


		display_Filename_LIB.text = " ";

	}
}
