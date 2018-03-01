using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour {
	public KeyCode startKey;

	void Update () {
		if (Input.GetKeyDown (startKey))
			SceneManager.LoadScene ("CHIXXX");
		
		
		
	}
}
