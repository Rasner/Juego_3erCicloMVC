using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulocontrolador : MonoBehaviour {

    public static Pendulocontrolador instance;
	// Use this for initialization
	public void Start () {
        instance = this;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void update()
    {
        PenduloModelo.instance._startTime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(PenduloModelo.instance._start, PenduloModelo.instance._end(Mathf.Sin(PenduloModelo.instance._startTime * PenduloModelo.instance._speed + Mathf.PI / 2) + 1.0f) / 2.0f);
    }
}
