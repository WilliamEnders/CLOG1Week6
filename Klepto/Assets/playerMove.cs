using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public float speed;
	private Transform body;

	// Use this for initialization
	void Start () {
		body = GameObject.Find ("Body").transform;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += body.forward * speed * Time.deltaTime * Input.GetAxis ("Vertical");
		transform.position += body.right * speed * Time.deltaTime * Input.GetAxis ("Horizontal");
	
	}
}
