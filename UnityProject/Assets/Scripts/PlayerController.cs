using UnityEngine;
using System.Collections;
	
public class PlayerController : MonoBehaviour {
	public float movementSpeed = 10;
	public Vector3 target;
	public Transform player;
	public float easeSpeed = 1f;
	public bool lockX = false;
	public bool lockY = false;
	public bool lockZ = false;
	public int currentLane = 0;

	// Use this for initialization
	void Start () {

	}
		
	// Update is called once per frame
	void Update () {
		Vector3 distanceToTarget = new Vector3 ();
		if (!lockX) {
			distanceToTarget.x = target.x - transform.position.x;
		}
		if (!lockY) {
			distanceToTarget.y = target.y - transform.position.y;
			}
		if (!lockZ) {
			distanceToTarget.z = target.z - transform.position.z;
		}
			
		transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);

		// Apply speed per second
		distanceToTarget.Scale (new Vector3 (easeSpeed * Time.deltaTime, easeSpeed * Time.deltaTime, easeSpeed * Time.deltaTime));
			
		// Add to current position
		distanceToTarget += transform.position;
			
		// Set it
		transform.position = distanceToTarget;
			

		if (Input.GetKeyDown (KeyCode.A)) {
			if(currentLane != -2){
			
			currentLane = currentLane -1;
			target = new Vector3(currentLane,0,0);
			}

		}
		if (Input.GetKeyDown (KeyCode.D)) {
			if(currentLane != 2){
			currentLane = currentLane +1;
			target = new Vector3(currentLane,0,0);
			}
		}
	}
}	
