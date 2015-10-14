using UnityEngine;
using System.Collections;

public class rotateBody : MonoBehaviour {

	private Transform neck;

	// Use this for initialization
	void Start () {
		neck = GameObject.Find ("Neck").transform;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = new Quaternion(0,neck.rotation.y,0,neck.rotation.w);
	}
}
