﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	
using UnityEngine.UI;
     

public class MenuNavigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void StartGame()
    {
            SceneManager.LoadScene(1);
    }

}
