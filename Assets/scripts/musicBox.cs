using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class musicBox : MonoBehaviour {

	public GameObject cover;
	public AudioSource audioSource;
	public AudioClip openBoxSound;
	public AudioClip musicboxSong;


	public void openBox()
	{
		Destroy (cover);
	}

	public void playMusic(){
		audioSource.PlayOneShot (musicboxSong);
	}
}
