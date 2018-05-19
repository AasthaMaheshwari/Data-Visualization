using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GUI_Button : MonoBehaviour {

	// Use this for initialization




	private void OnGUI(){

		if (GUI.Button (new Rect (400, 80, 200, 40), "TO PARENT DIRECTORY"))
			SceneManager.LoadScene ("parent",LoadSceneMode.Single);

	}

}
