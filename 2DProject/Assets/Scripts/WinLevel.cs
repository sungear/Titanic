﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WinLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "Player") {
            SceneManager.LoadScene("Victory");
        }
    }
}
