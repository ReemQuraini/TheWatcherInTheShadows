using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lightsOff : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip powerDown;
	public Text hintFlashlight;
	public AudioSource audioSourcePlayer;
	public AudioClip hintSound;
	private bool powerSoundPlayed;
	private bool triggerDone;

	void Start()
	{
		powerSoundPlayed = false;
		hintFlashlight.enabled = false;
		triggerDone = false;
		RenderSettings.ambientIntensity = 0.23f;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") &&powerSoundPlayed==false ) 
		{
			audioSource.PlayOneShot (powerDown);
			RenderSettings.ambientIntensity = 0.23f;
			powerSoundPlayed = true;
			//audioSource.PlayOneShot (hintSound);
			hintFlashlight.enabled = true;
		}
		else if (triggerDone) {
			Destroy (gameObject);
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player")) {

			triggerDone = true;
			Destroy (hintFlashlight);
		}
		else if (triggerDone) {
			Destroy (gameObject);
		}
	}
}
