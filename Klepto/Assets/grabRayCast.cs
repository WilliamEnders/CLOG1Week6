using UnityEngine;
using System.Collections;

public class grabRayCast : MonoBehaviour {
	public bool gotShaver;
	private Transform head;

	// Use this for initialization
	void Start () {
		head = GameObject.Find ("Head").transform;
		gotShaver = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		RaycastHit hitInfo; // variable to hold information about the raycast
		//if something is rayDistance away from this object from the front
		if(Input.GetKeyDown(KeyCode.E)){
			if ( Physics.Raycast( transform.position, transform.forward, out hitInfo, 20)) {
					if(hitInfo.collider.name == "Shaver"){
						if(!gotShaver){
						hitInfo.collider.transform.parent = head;
						hitInfo.collider.GetComponent<Rigidbody> ().useGravity = false;
						hitInfo.collider.GetComponent<BoxCollider> ().isTrigger = true;	
						hitInfo.collider.transform.localPosition = new Vector3 (0.6f, -0.4f, 0.6f);
						hitInfo.collider.transform.rotation = new Quaternion (0, 0, 0, 0);
						gotShaver = true;
						return;
						}
					}
				if(gotShaver){
					gotShaver = false;
				}
			}
		}
	}
}
