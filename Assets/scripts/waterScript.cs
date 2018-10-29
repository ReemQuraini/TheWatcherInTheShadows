using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class waterScript : MonoBehaviour {

	//public GameObject interact;
	public GameObject inter;
	// Use this for initialization
	void Start () {
	
		//inter = GetComponent<FirstPersonController> ();
		//interact = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ();
	}

	void OnTriggerEnter (Collider other){
		
		inter.GetComponent<FirstPersonController> ().walkingOnWater ();
	}

	void OnTriggerExit(Collider other)
	{
		inter.GetComponent<FirstPersonController> ().notWalkingOnWater ();
	}
}
