using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {


	public bool Jumped = false;
	public bool onFloor = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		if (Input.GetKeyDown (KeyCode.W)) {
			onFloor = false;
			rigidbody.AddForce(Vector3.up * 15, ForceMode.Impulse);
		}
		if (onFloor == false && Jumped == false) {
		}
	}
}
