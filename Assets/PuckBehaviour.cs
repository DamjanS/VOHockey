using UnityEngine;
using System.Collections;

public class PuckBehaviour : MonoBehaviour {
	public float speed = 4.0f;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = Vector2.one.normalized * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name == "player1") {
			// Calculate hit Factor
			float y=hitFactor(transform.position,
			                  col.transform.position,
			                  ((BoxCollider2D)col.collider).size.y);
			
			// Calculate direction, set length to 1
			Vector2 dir = new Vector2(1, y).normalized;
			
			// Set Velocity with dir * speed
			rigidbody2D.velocity = dir * speed;
		}
		
		// Hit the right Racket?
		if (col.gameObject.name == "player2") {
			// Calculate hit Factor
			float y=hitFactor(transform.position,
			                  col.transform.position,
			                  ((BoxCollider2D)col.collider).size.y);
			
			// Calculate direction, set length to 1
			Vector2 dir = new Vector2(-1, y).normalized;
			
			// Set Velocity with dir * speed
			rigidbody2D.velocity = dir * speed;
		}
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos,
	                float racketHeight) {
		// ascii art:
		// ||  1 <- at the top of the racket
		// ||
		// ||  0 <- at the middle of the racket
		// ||
		// || -1 <- at the bottom of the racket
		return (ballPos.y - racketPos.y) / racketHeight;
	}

}
