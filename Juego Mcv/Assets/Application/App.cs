using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementoApp : MonoBehaviour
{
	// Gives access to the application and all instances.
	public App app { get { return GameObject.FindObjectOfType<App>(); }}
}

public class App : MonoBehaviour {

	public ModeloHazard1 model1;
	public VistaHazard1 view1;
	public CotrnoladorHazard1 controller1;

	public ModeloPlayer Modelplayer;
	public VistaPlayer Viewplayer;
	public ControladorPlayer Controllerplayer;

	public ModeloJoystick Modeljoystick;
	public VistaJoystick Viewjoystick;
	public ControladorJoystick Controllerjoystick;

	public ModeloPendulo ModelPendulo;
	public VistaJoystick ViewPendulo;
	public ControladorJoystick ControllerPendulo;

	public ModeloTorre Modeltorre;
	public VistaJoystick Viewtorre;
	public ControladorJoystick Controllertorre;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
