using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	public bool open = false; //Door state 
	public float doorOpenAngle = 90f;
	public float doorCloseAngle = 0;
	public float smooth = 2f;  //speed of opening or closing door
	public AudioClip doorOpen;
	public AudioClip doorClose;
	public AudioClip doorLocked;
	public AudioSource audioSource;
	public bool isLocked = true;

	// Use this for initialization
	void Start () {
	
	}

	public void ChangeDoorState()
	{
		if (!isLocked) {//if door does not need key change state
			open = !open;

			if (open) { //if door opened, play audio
				audioSource.PlayOneShot (doorOpen);
			} else {
				audioSource.PlayOneShot (doorClose);
			}
		} else
			audioSource.PlayOneShot (doorLocked);
	

	}
	// Update is called once per frame
	void Update () 
	{
		if (open) 
		{
			Quaternion targetRotation= Quaternion.Euler(0,doorOpenAngle,0);     //rotational movement 
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, smooth*Time.deltaTime);

		}
		else
		{
			Quaternion targetRotation2= Quaternion.Euler(0,doorCloseAngle,0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation2, smooth*Time.deltaTime);

		}
	
	}
}
