using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour {
	public GUIText player1Text;
	public GUIText player2Text;
	private int player1Score;
	private int player2Score;

	// Use this for initialization
	void Start () {
		player1Score = 0;
		player2Score = 0;
		player1Text.text = player1Score.ToString();
		player2Text.text = player2Score.ToString();
	}

	public void AddPlayer1Score(){
		player1Score += 1;
		player1Text.text = player1Score.ToString();
	}

	public void AddPlayer2Score(){
		player2Score += 1;
		player2Text.text = player2Score.ToString();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
