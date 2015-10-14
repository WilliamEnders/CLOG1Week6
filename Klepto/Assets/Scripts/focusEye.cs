using UnityEngine;
using System.Collections;

public class focusEye : MonoBehaviour {

	private Animator face;

	// Use this for initialization
	void Start () {
		face = GameObject.Find ("Face").GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			GetComponent<Camera>().fieldOfView = 30f;
			face.Play ("squint");

		}
		if(Input.GetKeyUp(KeyCode.Space)){
			GetComponent<Camera>().fieldOfView = 45f;
			face.Play ("idle");
		}
	}
}
