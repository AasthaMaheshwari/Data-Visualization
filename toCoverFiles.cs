using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toCoverFiles : MonoBehaviour {

	void OnMouseDown()
	{
		
		SceneManager.LoadScene ("subchild_Cover",LoadSceneMode.Single);

	}
}


