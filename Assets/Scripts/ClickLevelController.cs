using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLevelController : MonoBehaviour {

	public static GameSystem.Difficulty difficulty;
	public int clicksToWin;
	public Transform turtle;
	public float remainingTime;
	public int currentClicks; 
	public Text timeText;
	private float step;

	// Use this for initialization
	void Start () {
		SetDifficultySettings();
		step = 11f / clicksToWin;
		currentClicks = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)) {
			currentClicks ++;
			turtle.Translate(step, 0,0);
		}

		timeText.text = "" + (int)remainingTime;

		remainingTime -= Time.deltaTime;

		if(remainingTime<= 0) {
			remainingTime = 0;
			GameSystem.FinishLevel(false);
		}

		if(currentClicks >= clicksToWin) {
			GameSystem.FinishLevel(true);
		}

	}

	void SetDifficultySettings() {
		var currentLevel = GameSystem.level;

		switch(currentLevel) {
			// Easy
			case 1: case 2:
				clicksToWin = 25;
				remainingTime  = 5f;
				break;
			// Medium
			case 3: case 4:
				clicksToWin = 20;
				remainingTime = 15f;
				break;
			// Hard
			default:
				clicksToWin = 30;
				remainingTime  = 10f;
				break;
		}
	}

}
