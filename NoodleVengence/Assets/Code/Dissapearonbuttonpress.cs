using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Dissapearonbuttonpress : PooledObject {

	public string letter;
	public Rigidbody2D Body { get; private set; }


	void Awake () {
		Body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (letter == "h")
		{
			if (Input.GetKeyDown (KeyCode.H)) 
			{
				Debug.Log ("pressed H");
				ReturnToPool ();
			}
		}else if (letter == "j")
		{
			if (Input.GetKeyDown (KeyCode.J)) 
			{
				Debug.Log ("pressed J");
				ReturnToPool ();
			}
		}else if (letter == "k")
		{
			if (Input.GetKeyDown (KeyCode.K)) 
			{
				Debug.Log ("pressed K");
				ReturnToPool ();
			}
		} else if (letter == "l")
		{
			if (Input.GetKeyDown (KeyCode.L)) 
			{
				Debug.Log ("pressed L");
				ReturnToPool ();
			}
		}
	}

	void OnTriggerEnter (Collider enteredCollider) {
		if (enteredCollider.CompareTag("Kill Zone")) {
			//ReturnToPool ();
			Destroy(gameObject);

		}
	}
}
