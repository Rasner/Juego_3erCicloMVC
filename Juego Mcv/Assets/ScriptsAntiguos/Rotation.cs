using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour
{
    public float speed = 5.0f;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
