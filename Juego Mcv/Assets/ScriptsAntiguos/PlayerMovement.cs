using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VirtualJoystick joystick;
    public float speed;
    //private Rigidbody RB3D;

    void Start()
    {
        //RB3D = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(speed * joystick.InputDirection * Time.deltaTime);
    }

    public void saltar (bool jump)
    {
        transform.Translate(100 * transform.up * Time.deltaTime);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "cchanger")
        {
            gamecontroller.instance.zona = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "cchanger")
        {
            gamecontroller.instance.zona = false;
        }
    }
}