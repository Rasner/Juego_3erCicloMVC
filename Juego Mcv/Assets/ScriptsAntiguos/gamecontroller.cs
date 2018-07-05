using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

    public static gamecontroller instance;
    public bool zona;
	// Use this for initialization
	void Start () {
        instance = this;
        zona = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
