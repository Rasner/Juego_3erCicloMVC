using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movpiso2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (piso.instance.choque == true)
        {
            StartCoroutine(cae());
        }
    }

    IEnumerator cae()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
