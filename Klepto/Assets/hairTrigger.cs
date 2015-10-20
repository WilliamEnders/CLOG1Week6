using UnityEngine;
using System.Collections;

public class hairTrigger : MonoBehaviour {

	private bool hit;

	// Use this for initialization
	void Start () {

		hit = false;
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider collisionInfo) {
		if(collisionInfo.name == "Shave"){
			if(!hit){
			gameObject.AddComponent<Rigidbody>();
			GetComponent<BoxCollider>().isTrigger = true;
				hit = true;
			}

		}
	
	}
}
