using UnityEngine;
using System.Collections;

public class HallGenerator : MonoBehaviour {

	public GameObject[] blocks;
	public Vector3 baseLoc = new Vector3(0,-0.6581007f,0);
	public Vector3 spawnLoc;
	public Vector3 baseRot = new Vector3(270, 90, 0);

	public float length;


	// Use this for initialization
	void Start () {
		Generate(0);
	}
	
	public void Generate(float zLoc){
		if(zLoc > length){
			Debug.Log("Done building");
		}
		else{
			Instantiate(blocks[getBlockType()], new Vector3(0,baseLoc.y,zLoc), Quaternion.Euler(baseRot));
			Generate(zLoc + 10);
		}
	}

	public void SpawnSingle(float zLoc){
		Instantiate(blocks[getBlockType()], new Vector3(0,baseLoc.y,zLoc), Quaternion.Euler(baseRot));
	}
	

	public int getBlockType(){
		return 0;
	}
}
