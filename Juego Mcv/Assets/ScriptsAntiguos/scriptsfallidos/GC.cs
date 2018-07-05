using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GC : MonoBehaviour {
    public bool puerta;
    public static GC instance;
    public GameObject puertaup;
    public GameObject puertadown;
    public GameObject player;

	// Use this for initialization
	void Start () {
        puerta = false;
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        if (GC.instance.puerta == true)
        {
            if (puertaup.transform.position.y < 3)
            {
                puertaup.transform.Translate(Vector3.up * Time.deltaTime);
            }
            if (puertadown.transform.position.y > 0)
            {
                puertadown.transform.Translate(Vector3.down * Time.deltaTime);
            }
        }

        if (GC.instance.puerta == false)
        {
            if (puertaup.transform.position.y > 2)
            {
                puertaup.transform.Translate(Vector3.down * Time.deltaTime);
            }
            if (puertadown.transform.position.y < 1)
            {
                puertadown.transform.Translate(Vector3.up * Time.deltaTime);
            }
        }

    }
}
