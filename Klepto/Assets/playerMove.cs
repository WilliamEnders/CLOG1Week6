using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public float speed;
	private Transform body;
	private Animator shoulder;
	private Transform cam;

	// Use this for initialization
	void Start () {
		body = GameObject.Find ("Body").transform;
		shoulder = GameObject.Find ("Shoulder").GetComponent<Animator>();
		cam = GameObject.Find ("Camera").transform;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cam.GetComponent<grabRayCast> ().gotShaver == false) {
			transform.position += body.forward * speed * Time.deltaTime * Input.GetAxis ("Vertical");
			transform.position += body.right * speed * Time.deltaTime * Input.GetAxis ("Horizontal");

			if (Input.GetKey (KeyCode.E)) {
				shoulder.Play ("Grab");

			}
	
		}
	}
}
