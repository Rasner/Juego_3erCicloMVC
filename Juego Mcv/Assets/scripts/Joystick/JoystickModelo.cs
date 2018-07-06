using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class JoystickModelo : MonoBehaviour
{
 
    public Image BT, JS;
    public Vector3 InputDirection { set; get; }

	public Vector2 pos;
	
	public static JoystickModelo instance;

    

    // Use this for initialization
    void Start () {
		instance = this;
		BT = GetComponent<Image>();
        JS = GetComponentsInChildren<Image>()[1];
        InputDirection = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
