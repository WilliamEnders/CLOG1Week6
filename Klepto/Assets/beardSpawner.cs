using UnityEngine;
using System.Collections;

public class beardSpawner : MonoBehaviour {

	public GameObject beardhair;
	private GameObject spawnedHair;

	// Use this for initialization
	void Start () {
		for(int i = 0; i<10;i++){
			spawnedHair = Instantiate (beardhair,Vector3.zero , transform.rotation) as GameObject;
			spawnedHair.transform.parent = transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		spawnedHair.transform.position = Vector3.zero;
	}
}
