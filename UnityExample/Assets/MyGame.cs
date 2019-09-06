using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.LogException(new Exception("LogDebugException clicked"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
