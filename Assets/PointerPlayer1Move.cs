using UnityEngine;
using System.Collections;

public class PointerPlayer1Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update (){

		var tapCount = Input.touchCount;
		for ( var i = 0 ; i < tapCount ; i++ ) {
			var touch = Input.GetTouch(i);
			if(touch.position.y<Screen.height/2){
				Debug.Log("Pozicija: X:"+touch.position.x+", Y:"+touch.position.y);
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				transform.position = new Vector3 (transform.position.x, ray.GetPoint(10f).y, transform.position.z);
			}
		}

	}
}
