using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AutoReplay : MonoBehaviour {
	float timer = 0;
	public Text info;
	int score ;
	

	// Use this for initialization
	void Start () {
		if ( EnemyController .EnemyKilled == 3)
		{
			info.text = ("Congratulation \n You Win !");
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 5) {
			score = 0;
			EnemyController.EnemyKilled = 0;
			SceneManager.LoadScene ("Gameplay");
		}
		
	}
}
