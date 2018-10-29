using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialTrigger : MonoBehaviour {


	public Text movement;
	//public Text camera;
	public Text door;
	public AudioSource audioSource;
	public AudioClip hintSound;
	private bool triggerDone;
	// Use this for initialization


	void Start()
	{
		audioSource.PlayOneShot (hintSound);
		movement.enabled = true;
		door.enabled = false;
		triggerDone = false;
	}



	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") && triggerDone == false) {
			audioSource.PlayOneShot (hintSound);

			movement.enabled = false;
			door.enabled = true;
		} else if (triggerDone) {
			Destroy (gameObject);
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player") && triggerDone == false) {
			door.enabled = false;
			triggerDone = true;
		} else if (triggerDone) {
			Destroy (gameObject);
		}


	}
		

}
