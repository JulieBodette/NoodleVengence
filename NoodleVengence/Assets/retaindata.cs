using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class retaindata : MonoBehaviour {

	public Text scoreText; //may have to move this to a score manager?
	public int score;
	public Text livesText;
	public int lives;


	public void Awake()
	{
		DontDestroyOnLoad (this);
	}
	public void increaseScore(int num)
	{
		score += num;
	}
	public void decreaseLives(int num)
	{
		lives -= num;
		if (lives <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
	}
		
	void Update () {
		if (scoreText != null) {
			scoreText.text = "Score: " + score.ToString ();	
		}
		if (livesText != null) {
			livesText.text = "Lives: " + lives.ToString ();	
		}
	}
}
