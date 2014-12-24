using UnityEngine;
using System.Collections;

public class PointerPlayer2Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		var tapCount = Input.touchCount;
		for ( var i = 0 ; i < tapCount ; i++ ) {
			var touch = Input.GetTouch(i);
			if(touch.position.y>Screen.height/2){
				Debug.Log("Pozicija: X:"+touch.position.x+", Y:"+touch.position.y);
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				transform.position = new Vector3 (transform.position.x, ray.GetPoint(10f).y, transform.position.z);
			}
		}
		if (tapCount == 0) {
			if(Input.mousePosition.y>Screen.height/2){
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				transform.position = new Vector3 (transform.position.x, ray.GetPoint(10f).y, transform.position.z);
			}
		}
		/*int randomNumber = Random.Range (1, 10);

			float randMove = Random.Range(-10.0f, 10.0f);
						float speed = 4.0f;
			Vector3 random = new Vector3();
						random.x = 0;
			random.y = randMove;
			random.z = 0;
			if (gameObject.transform.position.y > 2 && random.y > 0) random.y *= -1;
			else if (gameObject.transform.position.y < -2 && random.y < 0) random.y *= -1;
			transform.Translate (random * Time.deltaTime);
				*/
	}
}
