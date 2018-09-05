﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Init();
	}
	
	public void GameOver () {
		gameObject.GetComponent<Text>().enabled = true;
	}

	public void Init () {
		gameObject.GetComponent<Text>().enabled = false;
	}
}
