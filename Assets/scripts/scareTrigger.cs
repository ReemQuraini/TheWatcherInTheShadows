using UnityEngine;
using System.Collections;

public class scareTrigger : MonoBehaviour {

	public AudioSource ScareAudioSource;
	public AudioClip ScareSound;
	public Light PianoLight;

	private bool hasPlayedAudio = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") && hasPlayedAudio==false) 
		{
			ScareAudioSource.PlayOneShot (ScareSound);
			PianoLight.enabled = true;
			hasPlayedAudio = true;
		}

	}
}
