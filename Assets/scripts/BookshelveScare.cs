using UnityEngine;
using System.Collections;

public class BookshelveScare : MonoBehaviour {



	public AudioSource audioSource;
	public AudioClip smashSound;
	public bool smashSoundPlayed;
	public bool inLibrary;
	private int count;

	void Start()
	{
		smashSoundPlayed = false;
		inLibrary = false;
		count = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		
		inLibrary = true;
		if (other.CompareTag ("Player") &&smashSoundPlayed==false ) 
		{
			audioSource.PlayOneShot (smashSound);

		}

	}
	void OnTriggerExit()
	{
		count++;
		if (count == 2) {
			
			count = 0;
		}
	}
}
