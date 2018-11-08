using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneAfterLevelController : MonoBehaviour {

	public SpriteRenderer sprite;

	public Sprite[] lifes;
	public Text buttonText;

	// Use this for initialization
	void Start () {

		if (GameSystem.lifes < 3) {
			sprite.sprite = lifes[GameSystem.lifes];
		}

		if (GameSystem.lifes <= 0) {
			buttonText.text = "Intentar de nuevo";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ContinueGame() {
		if (buttonText.text.CompareTo("Intentar de nuevo") == 0) {
			GameSystem.ResetGame();	
		}
		SceneManager.LoadScene(1);
	}

}
