using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LevelLoad(string name) {
		Debug.Log ("Level load requested for: " + name);
		Application.LoadLevel (name);
	}

}
