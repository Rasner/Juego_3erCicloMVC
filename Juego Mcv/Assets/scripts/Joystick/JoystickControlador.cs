using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControlador : MonoBehaviour {

	// Use this for initialization
	void Start () {
        		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Ondrag(PointerEventData ped)
    {

    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        InputDirection = Vector3.zero;
        JS.rectTransform.anchoredPosition = Vector3.zero;
    }
}
