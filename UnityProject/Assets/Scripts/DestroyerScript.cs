using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	public HallGenerator hG;

	void Start(){
		hG = GameObject.Find("HallGenerator").GetComponent<HallGenerator>();
	}

	private void OnTriggerStay(Collider col)
	{
		Debug.Log ("Hit");

		if (col.gameObject.tag == "obstacle")
		{
			Debug.Log("Hit");
			Destroy(col.gameObject);
		}
	}
	private void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Hallway"){
			Destroy(col.gameObject);
			hG.SpawnSingle(col.gameObject.transform.position.z + hG.length +10);
		}
	}
}