using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class keyScript : MonoBehaviour {


	public DoorScript door;
	public AudioSource audioSource;
	public AudioClip pickupKey;
	public Text keyText;


	void Start()
	{
		keyText.enabled = false;

	}
	public void unlockDoor()
	{
		door.isLocked = false;
		audioSource.PlayOneShot (pickupKey);

		StartCoroutine ("WaitForSelfDestruct");

	}

	IEnumerator WaitForSelfDestruct ()
	{
		yield return new WaitForSeconds (pickupKey.length);
		Destroy (gameObject);
	}


}
