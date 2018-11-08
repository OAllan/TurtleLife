using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour {

	public Transform turtle;
	private float timeToLoad;

	// Use this for initialization
	void Start () {
		SetTurtleInPosition();
		timeToLoad = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		timeToLoad -= Time.deltaTime;
		if(timeToLoad <= 0) {
			GameSystem.LoadLevel();
		}
	}

	void SetTurtleInPosition() {
		turtle.position = GameSystem.GetTurtlePosition();
	}
}
