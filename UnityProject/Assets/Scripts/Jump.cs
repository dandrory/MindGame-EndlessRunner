using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {


	public float jumpForce = 15;
	public bool onFloor = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		if (Input.GetKeyDown (KeyCode.W) && onFloor) {
			transform.position = new Vector3(transform.position.x, 0.2f, transform.position.z);
			onFloor = false;
			rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}

	void OnCollisionStay(Collision col){
		if(col.gameObject.tag == "Floor"){
			onFloor = true;
		}
	}
}
