using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class toHooks : MonoBehaviour {

	void OnMouseDown()
	{
		SceneManager.LoadScene ("toHooks",LoadSceneMode.Single);
		
	}
}
