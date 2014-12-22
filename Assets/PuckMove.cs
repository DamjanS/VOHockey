using UnityEngine;
using System.Collections;

public class PuckMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.AddForce (rigidbody2D.velocity.normalized * 1, ForceMode2D.Impulse);
	}

	void FixedUpdate() {
		rigidbody2D.velocity = rigidbody2D.velocity.normalized * 1;
		rigidbody2D.AddForce (rigidbody2D.velocity.normalized * 1, ForceMode2D.Impulse);
		}

}
