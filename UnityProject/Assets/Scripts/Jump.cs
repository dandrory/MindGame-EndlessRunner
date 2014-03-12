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
				}
				if (onFloor == false && Jumped == false) {
			temp.y = temp.y + 0.2f;

				}
		if (temp.y >= 4) {
			Jumped = true;
				}
		if (temp.y <= 0.2f) {
			onFloor = true;
			Jumped = false;
		}
		if (Jumped == true && onFloor == false) {
			temp.y = temp.y - 0.4f;		
		}



		transform.position = temp;
		}
}
