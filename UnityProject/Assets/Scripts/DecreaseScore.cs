using UnityEngine;
using System.Collections;

public class DecreaseScore : MonoBehaviour {
	HUDScript hud;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			hud = GameObject.Find("_ScoreHandler").GetComponent<HUDScript> ();
			hud.IncreaseScore(-1000);
			Destroy (this.gameObject);
			
			
			
		}
	}
}