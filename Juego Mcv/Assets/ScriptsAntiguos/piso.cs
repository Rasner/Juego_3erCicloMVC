using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso : MonoBehaviour {

    public static piso instance;
    public bool choque;
	// Use this for initialization
	void Start ()
    {
        instance = this;
        choque = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "caer")
        {
            Debug.Log("choque");
            choque = true;
        }
    }
}
