using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public Image BT, JS;
    public Vector3 InputDirection { set; get; }

    private void Start()
    {
        BT = GetComponent<Image>();
        JS = GetComponentsInChildren<Image>()[1];
        InputDirection = Vector3.zero;
    }

    //EventSystems interfaces
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos = Vector2.zero;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle
            (   BT.rectTransform,
                ped.position,
                ped.pressEventCamera,
                out pos))
        {
            pos.x = (pos.x / BT.rectTransform.sizeDelta.x);
            pos.y = (pos.y / BT.rectTransform.sizeDelta.y);

            float x = (BT.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (BT.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            InputDirection = new Vector3(x, 0, y);
            InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;
            JS.rectTransform.anchoredPosition = new Vector3(InputDirection.x * (BT.rectTransform.sizeDelta.x / 3)
                , InputDirection.z * (BT.rectTransform.sizeDelta.y / 3));
        }
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
