using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	public GameObject balloon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		balloon.constantForce.force = new Vector3(0,5,0);

	}
}
