using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour {


	public Light flashLight;
	public AudioClip soundFlashLightOn;
	public AudioClip soundFlashLightOff;
	public AudioSource audioSource;
	private bool isPickedUp;
	private bool isActive;

	// Use this for initialization
	void Start () 
	{
		isActive = false;
		isPickedUp = true;
		flashLight.enabled = false; //flashlight is off
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
		if (Input.GetKeyDown (KeyCode.F)&& isPickedUp==true) //if flashlight is picked up, allow toggle
		{
			if (isActive == false) //toggle flashlight on
			{  
				flashLight.enabled = true;
				isActive = true;
				audioSource.PlayOneShot (soundFlashLightOn);
			}
			else if(isActive==true) //toggle flashlight off
			{
				flashLight.enabled = false;
				isActive = false;
				audioSource.PlayOneShot (soundFlashLightOff);
			}
		}
	
	}

	public void pickupFlashlight() 
	{
		isPickedUp = true;

	}
}
