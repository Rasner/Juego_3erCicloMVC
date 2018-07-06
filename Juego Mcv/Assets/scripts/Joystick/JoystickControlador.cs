using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JoystickControlador : MonoBehaviour,IDragHandler, IPointerUpHandler,IPointerDownHandler {

    public static JoystickControlador instance;
	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnDrag(PointerEventData ped)
    {
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle
            (JoystickModelo.instance.BT.rectTransform,
                ped.position,
                ped.pressEventCamera,
                out JoystickModelo.instance.pos))
        {
            JoystickModelo.instance.pos.x = (JoystickModelo.instance.pos.x / JoystickModelo.instance.BT.rectTransform.sizeDelta.x);
            JoystickModelo.instance.pos.y = (JoystickModelo.instance.pos.y / JoystickModelo.instance.BT.rectTransform.sizeDelta.y);

            float x = (JoystickModelo.instance.BT.rectTransform.pivot.x == 1) ? JoystickModelo.instance.pos.x * 2 + 1 : JoystickModelo.instance.pos.x * 2 - 1;
            float y = (JoystickModelo.instance.BT.rectTransform.pivot.y == 1) ? JoystickModelo.instance.pos.y * 2 + 1 : JoystickModelo.instance.pos.y * 2 - 1;

            JoystickModelo.instance.InputDirection = new Vector3(x, 0, y);
            JoystickModelo.instance.InputDirection = (JoystickModelo.instance.InputDirection.magnitude > 1) ? JoystickModelo.instance.InputDirection.normalized : JoystickModelo.instance.InputDirection;
            JoystickModelo.instance.JS.rectTransform.anchoredPosition = new Vector3(JoystickModelo.instance.InputDirection.x * (JoystickModelo.instance.BT.rectTransform.sizeDelta.x / 3)
                , JoystickModelo.instance.InputDirection.z * (JoystickModelo.instance.BT.rectTransform.sizeDelta.y / 3));
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        JoystickModelo.instance.pos = Vector2.zero;
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        JoystickModelo.instance.InputDirection = Vector3.zero;
        JoystickModelo.instance.JS.rectTransform.anchoredPosition = Vector3.zero;
    }
}
