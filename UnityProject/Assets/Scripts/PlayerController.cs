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
	public float currentLane = 0;


	//debounce variables;
	[HideInInspector]
	public bool dPressed, aPressed = false;

	// Use this for initialization
	void Start () {

	}
		
	// Update is called once per frame
	void FixedUpdate () {
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
				if(!aPressed){
					aPressed = true;
					currentLane--;
					Debug.Log(currentLane);
					target = new Vector3(currentLane,0,0);
				}
			}

		}
		if (Input.GetKeyDown (KeyCode.D)) {
			if(currentLane != 2){
				if(!dPressed){
					dPressed = true;
					currentLane++;
					target = new Vector3(currentLane,0,0);
				}
			}
		}

		if (Input.GetKeyUp (KeyCode.D)) {
			dPressed = false;
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			aPressed = false;
		}
	}
}	
