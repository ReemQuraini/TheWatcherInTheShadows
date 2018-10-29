using UnityEngine;
using System.Collections;

public class JulianTrigger : MonoBehaviour {

	public GameObject julian;
	public Light light;
	public AudioSource audioSource;
	public AudioClip scaryEffect;

	// Use this for initialization
	void Start () {
	
		julian.SetActive (false);
		light.enabled = false;

	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			julian.SetActive (true);
			audioSource.PlayOneShot (scaryEffect);
			light.enabled = true;

		}

	}

	IEnumerator WaitForSelfDestruct ()
	{

		yield return new WaitForSeconds (scaryEffect.length);
		Destroy (gameObject);
	}

	void OnTriggerExit(Collider other)
	{
		
		Destroy (julian);
		Destroy (light);
		StartCoroutine ("WaitForSelfDestruct");
		Destroy (gameObject);
	}
}
