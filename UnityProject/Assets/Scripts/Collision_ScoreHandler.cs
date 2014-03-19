using UnityEngine;
using System.Collections;

public class Collision_ScoreHandler: MonoBehaviour {
	HUDScript hud;
	public float amount;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			hud = GameObject.Find("_ScoreHandler").GetComponent<HUDScript> ();
			hud.IncreaseScore(amount);
			Destroy (this.gameObject);
		}
	}
}