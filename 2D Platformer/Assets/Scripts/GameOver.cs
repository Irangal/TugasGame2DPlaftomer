using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;

public class GameOver : MonoBehaviour {
	public Text txScore;
	public Text txHighScore;
	Text txSelamat;
	int highscore;
	Text ScoreUI;
	int Score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		highscore = PlayerPrefs.GetInt("HS", 0);
		if (Score > highscore )
			{
			highscore = Score  ;
			PlayerPrefs.SetInt("HS", highscore);
			}
		else if (EnemyController.EnemyKilled == 3)
			{
			SceneManager.LoadScene("Congratulations")
			;
			}
		txHighScore.text = "Highscores: " + highscore;
		txScore.text = "Scores : " + Score ;
		}
		public void Replay()
	{
		Score = 0;
		EnemyController.EnemyKilled = 0;
		SceneManager.LoadScene("Gameplay");
		
	}
}
