﻿// VR at SAIC 
// Unity Scritping
// Basic scripts to get started with scripting in Unity 3D
// Feel free to edit and change as needed

using UnityEngine;
using System.Collections;

public class Translation : MonoBehaviour {
	public float moveSpeed = .5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);
//
//		transform.Translate(Vector3.up * Time.deltaTime);
//		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		transform.Translate(Vector3.forward * .03f);
		// check other options such as Vector3.forward, etc. 

		// transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);

	}
}
