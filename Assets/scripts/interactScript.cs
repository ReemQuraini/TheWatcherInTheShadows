using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class interactScript : MonoBehaviour
{

	public string interactButton;

	public float interactionDistance = 3f;
	public LayerMask interactLayer;
	//filter

	public musicBox box;
	public Image interactionIcon;
	public Text hintFlashlight;
	public bool isInteracting;
	public AudioSource audioSurce;
	//public Text hintParts;

	private bool musicboxSongPlayed;
	public int[] drum;
	private int countDrums;
	//private flashlight light;

	void Start ()
	{
		//light=GetComponent<flashlight> ();
		//GetComponent<flashlightobj> ();

		//drum[]=new int[4];
		musicboxSongPlayed = false; 
		countDrums = 0;
//		hintParts.enabled = false;
		//set interaction icon to be invisible
		if (interactionIcon != null) {
			interactionIcon.enabled = false;

		}

	}

	void Update ()
	{
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		if (countDrums == 4 && musicboxSongPlayed == false) {
			box.playMusic ();
			musicboxSongPlayed = true;
		}
		//shoots a ray
		if (Physics.Raycast (ray, out hit, interactionDistance, interactLayer)) {
			//checks if we are not interacting
			if (isInteracting == false) {
				if (interactionIcon != null) {
					interactionIcon.enabled = true;
				}

				//if we press the interaction button
				if (Input.GetButtonDown (interactButton)) {
					//if it's a door
					if (hit.collider.CompareTag ("Door")) {
						//Open,close door
						hit.collider.GetComponent<DoorScript> ().ChangeDoorState ();
					} 
					//if it's a key
					else if (hit.collider.CompareTag ("Key")) {
						hit.collider.GetComponent<keyScript> ().unlockDoor ();
					} 
					//if it's a flashlight
					else if (hit.collider.CompareTag ("Flashlight")) {
						hit.collider.GetComponent<flashlightobj> ().pickup (); //pickup the flashlight
						//Destroy(hintFlashlight);
						hintFlashlight.text = "Hint: Press F to turn on flashligh";

						//light.GetComponent<flashlight> ().pickupFlashlight ();
					}

					//if it's a Note
					else if (hit.collider.CompareTag ("Note")) {
						hit.collider.GetComponent<Note> ().showNote ();
					
					} else if (hit.collider.CompareTag ("MusicBox") && musicboxSongPlayed) {

						if (countDrums == 4) {
							hit.collider.GetComponent<musicBox> ().openBox ();
						} else {
							//hintParts.enabled = true;
						}
					} else if (hit.collider.CompareTag ("R1") || hit.collider.CompareTag ("R2") || hit.collider.CompareTag ("R3") || hit.collider.CompareTag ("R4")) {
						
						hit.collider.GetComponent<drums> ().Place ();
						countDrums++;

					}

				}

			}

		} else {
			interactionIcon.enabled = false;
		}
	}
}



