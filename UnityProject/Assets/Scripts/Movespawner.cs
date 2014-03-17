using UnityEngine;
using System.Collections;

public class Movespawner : MonoBehaviour {

	public float movementSpeed = 10;
	public Vector3 target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
	
	}
}
