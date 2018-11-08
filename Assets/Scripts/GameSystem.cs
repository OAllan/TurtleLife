using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

	public static int lifes;
	public static AudioSource gameAudio;
	public static Vector2 startPlace;
	public static Vector2 target;
	private static Vector2[] levelCoordinates = {new Vector2(1.41f, 1.02f), new Vector2(5.25f, -0.11f), new Vector2(-0.54f, -2.93f), new Vector2(3.41f, -4.07f), new Vector2(7.64f, -4.62f)};
	public static int level;
	public static int[] levels = {2};
	public enum Difficulty {
		EASY,
		MEDIUM,
		HARD
	}

	// Use this for initialization
	void Start () {
		gameAudio = GetComponent<AudioSource>();
		DontDestroyOnLoad(gameObject);
		lifes = 3;
		level = 1;
		target = new Vector2(1.41f, 1.02f);
		startPlace = new Vector2(-3.44f, 1.22f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PauseMusic() {
		gameAudio.Pause();
	}

	public static void FinishLevel(bool win) {
		if(win) {
			level++;
			LoadSceneAfterLevel();
		} else {
			lifes--;
			LoadSceneAfterLevel();
		}
	}

	public static void PlayMusic() {
		gameAudio.Play();
	}

	public static Vector2 GetTurtlePosition(){
		return levelCoordinates[level-1];
	}

	public static void LoadLevel() {
		SceneManager.LoadScene(levels[level-1]);
	}

	private static void LoadSceneAfterLevel(){
		SceneManager.LoadScene(3);
	}

	public static void ResetGame() {
		lifes = 3;
		level = 1;
	}
}
