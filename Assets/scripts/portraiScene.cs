using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class portraiScene : MonoBehaviour {

	public RawImage scene;
	public Canvas can;
	public AudioSource audioSource;
	public AudioClip sceneSound;

	public GameObject playerObject;


	void Start()
	{
		can.enabled = false;
		scene.enabled = false;

	}

	void Update()
	{
		
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			if(scene.enabled)
				skip ();
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			can.enabled = true;
			scene.enabled = true;
			showScene ();
		}
	}

	public void showScene()
	{
		can.enabled = true;
		scene.enabled = true;

		//((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
		//AudioSource audio = GetComponent<AudioSource>();
		//saudio.Play(); 

		audioSource.PlayOneShot (sceneSound); 

		playerObject.GetComponent<FirstPersonController> ().enabled = false;

		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		StartCoroutine ("WaitForSelfDestruct");
	}

	public void skip()
	{
		scene.enabled = false;

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		playerObject.GetComponent<FirstPersonController> ().enabled = true;

		Destroy (gameObject);
	}
	IEnumerator WaitForSelfDestruct ()
	{
		yield return new WaitForSeconds (sceneSound.length);
		scene.enabled = false;

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		playerObject.GetComponent<FirstPersonController> ().enabled = true;
	}

}
