using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform player;
	public float zHeight = 1;
	public float trailDistance = 7;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.position.x,zHeight, player.position.z - trailDistance);
		transform.LookAt(player);
	}
}
