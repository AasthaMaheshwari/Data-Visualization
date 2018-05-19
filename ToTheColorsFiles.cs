using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheColorsFiles : MonoBehaviour {

	void OnMouseDown()
	{
		//Debug.Log ("To the Parent Directory");
		SceneManager.LoadScene ("filesOfColors",LoadSceneMode.Single);

	}
}
