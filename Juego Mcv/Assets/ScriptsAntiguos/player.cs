using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public Transform respawn;
    public float speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, speed * Input.GetAxis("Horizontal") * Time.deltaTime);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "puerta")
        {
            transform.position = respawn.position;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "button")
        {
            GC.instance.puerta = true;
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "button")
        {
            transform.parent = null;
            GC.instance.puerta = false;
        }
    }

}
