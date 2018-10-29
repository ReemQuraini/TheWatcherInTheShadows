using UnityEngine;
using System.Collections;

public class flashlightobj : MonoBehaviour {

	public flashlight light;
	public AudioSource audioSource;
	public AudioClip flashPickupSound;

	//public Material outlined;
	//public GameObject obj;


	public void pickup() //flags flashlight as picked up and removes object from scene
	{
		light.pickupFlashlight ();
		audioSource.PlayOneShot (flashPickupSound);

		StartCoroutine ("WaitForSelfDestruct");
	}

	IEnumerator WaitForSelfDestruct ()
	{
		yield return new WaitForSeconds (flashPickupSound.length);
		Destroy (gameObject);
	}

	//public void glow()
	//{
		//obj.renderer.
	//}
}
