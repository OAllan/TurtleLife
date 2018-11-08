using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour {

	private bool isPlaying;
	private Image buttonImage;
	private Color baseColor;

	// Use this for initialization
	void Start () {
		buttonImage = GetComponent<Image>();
		baseColor = buttonImage.color;
		isPlaying = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonClick() {
		isPlaying = !isPlaying;
		
		if(isPlaying) {
			GameSystem.PlayMusic();
			buttonImage.color = baseColor;
		} else {
			GameSystem.PauseMusic();
			buttonImage.color = Color.gray;
		}

	}
}
