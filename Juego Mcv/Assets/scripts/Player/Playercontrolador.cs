using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrolador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void movement()
    {
        transform.Translate(PlayerModelo.instance.speed * JoystickModelo.instance.InputDirection * Time.deltaTime);
    }
}
