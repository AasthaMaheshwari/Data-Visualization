using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveMouse : MonoBehaviour {

	public Text display_Filename;

	// Use this for initialization
	void Start () {

		display_Filename = GameObject.Find ("Canvas").GetComponentInChildren<Text> ();
		
	}

	void OnMouseOver()
	{
		display_Filename.text = "Root";
	}

	// Update is called once per frame
	void OnMouseExit(){
		
		display_Filename.text = " ";
		
	}
}
