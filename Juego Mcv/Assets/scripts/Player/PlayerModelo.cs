using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModelo : MonoBehaviour {
  public VirtualJoystick joystick;
    public float speed;
	public static PlayerModelo instance;
	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
