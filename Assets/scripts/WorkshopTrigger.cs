using UnityEngine;
using System.Collections;

public class WorkshopTrigger : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip workshopMusic;
	private bool triggerDone;
	private int count;

	// Use this for initialization
	void Start () {
		triggerDone = false;
		count = 0;
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") && triggerDone==false) {
			audioSource.Play ();
			triggerDone = true;
		}

	}

	void OnTriggerExit(Collider other)
	{
		count++;

		if (count == 2) {
			audioSource.Stop ();
			count = 0;
			triggerDone = false;
		}
	}
}
