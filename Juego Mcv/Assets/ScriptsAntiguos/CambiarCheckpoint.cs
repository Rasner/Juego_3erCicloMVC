using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCheckpoint : MonoBehaviour {
    public GameObject checkpoint;
	// Use this for initialization
	void OntriggerEnter (Collider plyr) {
		if (plyr.gameObject.tag == "Player")
        {
            Destroy(checkpoint);
            Destroy(gameObject);
        }
	}   
	
}
