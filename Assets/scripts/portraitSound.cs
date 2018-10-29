using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class portraitSound : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip portraitS;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			
			audioSource.PlayOneShot (portraitS);

			StartCoroutine ("WaitForSelfDestruct");
		}

	}

	 IEnumerator WaitForSelfDestruct ()
	{
		yield return new WaitForSeconds (portraitS.length);
		Destroy (gameObject);
	}

}
