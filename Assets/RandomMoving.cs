using UnityEngine;
using System.Collections;

public class RandomMoving : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int randomNumber = Random.Range (1, 10);

			float randMove = Random.Range(-10.0f, 10.0f);
						float speed = 4.0f;
			Vector3 random = new Vector3();
						random.x = 0;
			random.y = randMove;
			random.z = 0;
			if (gameObject.transform.position.y > 2 && random.y > 0) random.y *= -1;
			else if (gameObject.transform.position.y < -2 && random.y < 0) random.y *= -1;
			transform.Translate (random * Time.deltaTime);
				
	}
}
