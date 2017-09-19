using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class retaindata : MonoBehaviour {

	public Text scoreText; //may have to move this to a score manager?
	public int score;

	public void Awake()
	{
		DontDestroyOnLoad (this);
	}
	public void increaseScore(int num)
	{
		score += num;
	}
		
	void Update () {
		if (scoreText != null) {
			scoreText.text = "Score: " + score.ToString ();	
		}
	}
}
