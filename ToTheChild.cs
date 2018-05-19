using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheChild : MonoBehaviour {

	private void OnGUI(){

		if (GUI.Button (new Rect (350,140,200,40), "CBSoftware HTML: CSS Scripts"))
			SceneManager.LoadScene ("child",LoadSceneMode.Single);

	}

}
