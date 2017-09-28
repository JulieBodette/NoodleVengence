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
	public int levelnum;


	public void Awake()
	{
		DontDestroyOnLoad (this);
		DontDestroyOnLoad (scoreText.transform.parent.gameObject);//get acess to canvas
		//keep canvas in between scenes

		//destroy multiple copies of the script
		//eg when you start level 1 again, a new copy will spawn and we need to get rid of it
		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		} 

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
	public void GotoNextLevel()
	{
		//called at the end of every level, takes you to the next one
		if (levelnum == 1) {
			levelnum += 1;
			score = 0;
			SceneManager.LoadScene ("level2");
		} else if (levelnum == 2) {
			levelnum += 1;
			score = 0;
			SceneManager.LoadScene ("level3");
		}else if (levelnum == 3) {
			score = 0;
			SceneManager.LoadScene ("YouWin");
		}

		Debug.Log ("Level num is: " + levelnum);
	}
		
	void Update () {
		if (scoreText != null) {
			scoreText.text = "Score: " + score.ToString ();	
		}
		if (livesText != null) {
			livesText.text = "Lives: " + lives.ToString ();	
		}
		//Determine if it is time to go to next level
		if (levelnum == 1 && score >= 5) {
			GotoNextLevel ();
		} else if (levelnum == 2 && score >= 20) {
			GotoNextLevel ();
		}else if (levelnum == 3 && score >= 50) {
			GotoNextLevel ();
		}
	}
}
