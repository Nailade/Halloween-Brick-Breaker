﻿using UnityEngine;
using System.Collections;

public class AmbientSound : MonoBehaviour {

	static AmbientSound instance = null;
	
	
	void Awake () {
	
	//Debug.Log ("Music Player Awake" + GetInstanceID());
		if (instance != null) {
			Destroy (gameObject);
			print ("destroy dupe ambient");
			
			
			
		}else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
			
			
		}
		
		
	}
	
	
	void Start () {
	
	//Debug.Log ("Music Player Start" + GetInstanceID());

	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}

}
