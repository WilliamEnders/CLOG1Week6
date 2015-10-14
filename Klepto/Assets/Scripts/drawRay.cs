using UnityEngine;
using System.Collections;

public class drawRay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnDrawGizmos () {
		Gizmos.DrawRay (transform.position, transform.forward * 5f);
	}
}
