using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text>().enabled = false;
	}
	
	public void GameOver () {
		gameObject.GetComponent<Text>().enabled = true;
	}
}
