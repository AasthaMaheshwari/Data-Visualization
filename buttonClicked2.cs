using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonClicked2 : MonoBehaviour {

	public void OnGUI()
	{
		if (GUI.Button(new Rect(100, 200, 200, 30), "BACK TO CHILD"))
			SceneManager.LoadScene ("childOfCB",LoadSceneMode.Single);
	}
}
