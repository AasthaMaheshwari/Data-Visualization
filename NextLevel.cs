using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	void OnMouseDown()
	{
		Debug.Log ("To the Parent Directory");
		SceneManager.LoadScene ("parent",LoadSceneMode.Single);

	}
}


