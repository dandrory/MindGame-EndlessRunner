using UnityEngine;
using System.Collections;

public class Spawnline : MonoBehaviour {
	
	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public int currentLane = 0;
	public Transform[] spawnLoc;
	
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn () {
		Instantiate(obj[Random.Range ((int)0, obj.GetLength(0))], spawnLoc[(int)Random.Range(0,spawnLoc.GetLength(0))].position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}