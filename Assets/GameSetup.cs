using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	
	public Camera mainCamera;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;
	
	Transform Player1;
	Transform Player2;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Move wall to location
		topWall.size = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f); 
		topWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f);
		
	}
}
