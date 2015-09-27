﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

	private Vector3 origin;
	public GameObject focusedObject;

	// Use this for initialization
	void Start ()
	{
		origin = transform.position;
	}
	
	void FixedUpdate ()
	{
		if (!focusedObject) {
			return;
		}
		origin.x = focusedObject.transform.position.x;
		transform.position = origin;
	}
}
