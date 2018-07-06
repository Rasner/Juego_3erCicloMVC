using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulocontrolador : MonoBehaviour {
    public static Pendulocontrolador instance;
    // Use this for initialization
    public void Start() {
        instance = this;
    }

    // Update is called once per frame
    void Update() {

    }

    public void pendulomov()
    {
        PenduloModelo.instance._startTime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(PenduloModelo.instance._start, PenduloModelo.instance._end, (Mathf.Sin(PenduloModelo.instance._startTime * PenduloModelo.instance._speed + Mathf.PI / 2) + 1.0f) / 2.0f);
    }

    public Quaternion PenduloRotation(float angle)
    {
        var PenduloRotation = transform.rotation;
        var angleZ = PenduloRotation.eulerAngles.z + angle;

        if (angleZ > 180)
            angleZ -= 360;
        else if (angleZ < -180)
            angleZ += 360;

        PenduloRotation.eulerAngles = new Vector3(PenduloRotation.eulerAngles.x, PenduloRotation.y, angleZ);
        return PenduloRotation;
    }
}
