using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		//later do the object pool thingy
		Destroy(other.gameObject);
		Debug.Log ("object destroyed in kill zone");
		GameObject.FindObjectOfType<retaindata>().decreaseLives(1); 
	}
}
