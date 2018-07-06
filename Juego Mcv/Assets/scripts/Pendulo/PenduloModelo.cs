using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenduloModelo : MonoBehaviour {
	public	Quaternion _start, _end;
	// Use this for initialization
	[SerializeField, Range (0.0f, 360f)]
	public float _angle = 90f;
	[SerializeField, Range(0.0f, 5.0f)]
	public float _speed = 2.0f;
	[SerializeField, Range (0.0f, 10.0f)]
	public float _startTime = 0.0f;

	public static PenduloModelo instance;
	// Use this for initialization
	void Start () {
		instance = this;
		_start = PendulumRotation (_angle);
		_end = PendulumRotation (-_angle);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
