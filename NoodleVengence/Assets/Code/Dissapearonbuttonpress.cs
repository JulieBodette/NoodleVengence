﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Dissapearonbuttonpress : MonoBehaviour {

	public string letter;
	public Vector2 v;
	public Rigidbody2D Body { get; private set; }


	void Awake () {
		Body = GetComponent<Rigidbody2D>();
		Body.velocity = v;
	}
	public void setVelocity(Vector2 newVelocity)
	{
		Body.velocity = newVelocity;
	}

	void CheckKeyPress()
	{
		if (letter == "h")
		{
			if (Input.GetKeyDown (KeyCode.H)) 
			{
				GameObject.FindObjectOfType<retaindata>().increaseScore (1); 
				Destroy(gameObject);
			}
		}else if (letter == "j")
		{
			if (Input.GetKeyDown (KeyCode.J)) 
			{
				GameObject.FindObjectOfType<retaindata>().increaseScore (1); 
				Destroy(gameObject);
			}
		}else if (letter == "k")
		{
			if (Input.GetKeyDown (KeyCode.K)) 
			{
				GameObject.FindObjectOfType<retaindata>().increaseScore (1); 
				Destroy(gameObject);
			}
		}else if (letter == "l")
		{
			if (Input.GetKeyDown (KeyCode.L)) 
			{
				GameObject.FindObjectOfType<retaindata>().increaseScore (1); 
				Destroy(gameObject);
			}
		} 
		else if (letter == ";")
		{
			if (Input.GetKeyDown (KeyCode.Semicolon)) 
			{
				GameObject.FindObjectOfType<retaindata>().increaseScore (1); 
				Destroy(gameObject);
			}
		}
	}

	void OnTriggerStay2D(Collider2D other)
	{

		if (other.tag == "Grab Zone") {
			CheckKeyPress (); //check to see if player is pressing correct key to pick noodle up
			//add chopsticks animation here
		} else if (other.tag == "Kill Zone") {
			Debug.Log ("Dropped a noodle!! oh noes");
		}
	}
	/*
	void OnTriggerEnter (Collider enteredCollider) {
		if (enteredCollider.CompareTag("Kill Zone")) {
			//ReturnToPool ();
			Destroy(gameObject);

		}
	}*/
}
