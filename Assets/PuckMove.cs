using UnityEngine;
using System.Collections;

public class PuckMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("helo");
		rigidbody2D.AddForce (collision.relativeVelocity, ForceMode2D.Impulse);
	}


	void FixedUpdate() {

		rigidbody2D.velocity = rigidbody2D.velocity.normalized * 4;
		rigidbody2D.AddForce (rigidbody2D.velocity.normalized * 4, ForceMode2D.Impulse);
		}

	void LateUpdate() {
				rigidbody2D.velocity = rigidbody2D.velocity.normalized * 10;
		}
}
