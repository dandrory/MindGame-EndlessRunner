using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	private void OnTriggerStay(Collider col)
	{
		Debug.Log ("Hit");

		if (col.gameObject.tag == "obstacle")
		{
			Debug.Log("Hit");
			Destroy(col.gameObject);
		}
	}
}