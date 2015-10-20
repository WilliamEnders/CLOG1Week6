using UnityEngine;
using System.Collections;

public class beardMaker : MonoBehaviour {

	public GameObject hair;

	// Use this for initialization
	void Start () {
		for(float i=0;i<25;i++){
			for(float j=0;j<5;j++){
			GameObject spawnedHair = Instantiate(hair, Vector3.zero, Quaternion.identity) as GameObject;
			spawnedHair.transform.parent = transform;
			spawnedHair.transform.localPosition = new Vector3(-0.51f+(i/25),0.1f - (j/20),0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
