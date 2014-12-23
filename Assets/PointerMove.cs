using UnityEngine;
using System.Collections;

public class PointerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update (){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		transform.position = new Vector3 (transform.position.x, ray.GetPoint(10f).y, transform.position.z);
	}
}
