using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class Note : MonoBehaviour {
	public Image note;
	public AudioSource audioSource;
	public AudioClip pickupNote;
	public AudioClip putawayNote;

	public GameObject playerObject;
	public GameObject hideNoteBtn;


	void Start()
	{
		note.enabled = false;
		hideNoteBtn.SetActive (false); 
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			if(note.enabled)
				hideNote ();
		}
		else if (Input.GetKeyDown (KeyCode.Space)) 
		{

		}
	}

	public void showNote()
	{
		note.enabled = true;
		audioSource.PlayOneShot (pickupNote);
		hideNoteBtn.SetActive (true); 

		playerObject.GetComponent<FirstPersonController> ().enabled = false;
		 
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void hideNote()
	{
		note.enabled = false;
		audioSource.PlayOneShot (putawayNote);

		hideNoteBtn.SetActive (false); 

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		playerObject.GetComponent<FirstPersonController> ().enabled = true;
	}
}
