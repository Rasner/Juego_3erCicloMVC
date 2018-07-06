using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class JoystickModelo : MonoBehaviour, IDragHandler,  IPointerUpHandler, IPointerDownHandler
{
 {
    public Image BT, JS;
    public Vector3 InputDirection { set; get; }
	
	public static JoystickModelo instance;

    

    // Use this for initialization
    void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
