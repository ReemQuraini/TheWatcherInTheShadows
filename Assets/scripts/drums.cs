using UnityEngine;
using System.Collections;

public class drums : MonoBehaviour {

	//public float positionX;
	//public float positionY;
	//public float positionZ;

	public AudioSource audioSource;
	public AudioClip pickUpSound;
	public GameObject obj;


	public void Place()
	{
		obj.SetActive (true);

		audioSource.PlayOneShot (pickUpSound);

		StartCoroutine ("WaitForSelfDestruct");

	}

	IEnumerator WaitForSelfDestruct ()
	{
		
		yield return new WaitForSeconds (pickUpSound.length);
		Destroy (gameObject);
	}
}
