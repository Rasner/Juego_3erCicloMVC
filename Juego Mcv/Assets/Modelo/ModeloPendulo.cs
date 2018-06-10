using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloPendulo : ElementoApp {
	Quaternion _start, _end;
	// Use this for initialization
	[SerializeField, Range (0.0f, 360f)]
	private float _angle = 90f;
	[SerializeField, Range(0.0f, 5.0f)]
	private float _speed = 2.0f;
	[SerializeField, Range (0.0f, 10.0f)]
	private float _startTime = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
