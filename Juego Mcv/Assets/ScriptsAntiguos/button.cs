using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GC.instance.puerta == true && transform.position.y >32.5)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (GC.instance.puerta == false && transform.position.y < 33)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
    }
}
