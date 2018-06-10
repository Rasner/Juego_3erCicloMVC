using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VirtualJoystick joystick;
    public float speed;
    //private Rigidbody RB3D;

    private void Start()
    {
        //RB3D = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //RB3D.AddForce(joystick.InputDirection * speed * Time.deltaTime);
        transform.Translate(speed * joystick.InputDirection * Time.deltaTime);
        /*if (salto == 1 && jump == true)
        {
            transform.Translate(0, 15, 0);
            salto = 0;
        }
        */
    }

    /*public void OnCollisionEnter(Collision collision)
    {
        salto = 1;
    }
    */

    public void saltar (bool jump)
    {
        transform.Translate(100 * transform.up * Time.deltaTime);
    }
}