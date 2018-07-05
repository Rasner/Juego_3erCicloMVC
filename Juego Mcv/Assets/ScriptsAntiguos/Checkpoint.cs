using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {
    public Transform checkpoint;
    public int vida;
    GameObject player;
    // Use this for initialization
    void Start () {
        vida = 3;
        player = GameObject.FindWithTag("Player");

	}

    void Update()
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene(2);
        }    
    }
    // Update is called once per frame
    void  OnTriggerEnter(Collider plyr) {
		if (plyr.gameObject.tag == "Player")
        {
            vida -= 1;
            
            player.transform.position = checkpoint.position;
            //player.transform.rotation = checkpoint.rotation;
        }
	}
}
