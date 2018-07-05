using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarita : MonoBehaviour
{

    public Transform player;
    public Transform tpdwn;
    public Transform tudi;
    //public Vector3 offset;
    public float speed;

    // Use this for initialization
    void Start()
    {
        //rotar = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gamecontroller.instance.zona == false)
        {
            transform.position = Vector3.Lerp(transform.position, tudi.position, Time.deltaTime * speed);
            transform.rotation = Quaternion.Lerp(transform.rotation, tudi.rotation, Time.deltaTime * speed);
        }

        if (gamecontroller.instance.zona == true)
        {
            transform.position = Vector3.Lerp(transform.position, tpdwn.position, Time.deltaTime * speed);
            transform.rotation = Quaternion.Lerp(transform.rotation, tpdwn.rotation, Time.deltaTime * speed);

        }
    }
}
