using UnityEngine;
using System.Collections;

public class shaverMove : MonoBehaviour {

	private Transform cam;
	private float speed;

	// Use this for initialization
	void Start () {

		cam = GameObject.Find ("Camera").transform;
		speed = 5f;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cam.GetComponent<grabRayCast> ().gotShaver) {
			if (Input.GetKeyDown (KeyCode.E)) {
				transform.parent = null;
				GetComponent<Rigidbody> ().useGravity = true;
				GetComponent<BoxCollider> ().isTrigger = false;
				
				
			}
			transform.position += cam.up * speed * Time.deltaTime * Input.GetAxis ("Vertical");
			transform.position += cam.right * speed * Time.deltaTime * Input.GetAxis ("Horizontal");
		}
	}
}
