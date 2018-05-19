using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotheSubchild : MonoBehaviour {
	
	void OnMouseDown()
	{
		//Debug.Log ("To the Parent Directory");
		SceneManager.LoadScene ("subChild_Images",LoadSceneMode.Single);

	}
}


