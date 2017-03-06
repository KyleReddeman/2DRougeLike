using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public BoardManager boardScript;

	private int level;
	// Use this for initialization
	void Awake () {
		boardScript = GetComponent<BoardManager>();
		level = 20;
		InitGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitGame() {
		boardScript.SetupScene(level);
	}
}
