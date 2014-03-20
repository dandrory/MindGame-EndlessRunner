using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	
	float playerScore = 0;
	float playerDistance = 0;
	GameObject player;

	void Start(){
		player = GameObject.FindWithTag("Player");
	}
	
	void Update (){
		playerScore += player.transform.position.z - (player.transform.position.z-1);
		playerDistance = player.transform.position.z;
	}
	
	public void IncreaseScore(float amount)
	{ 
		playerScore += amount;
	}
	
	void OnGUI()
	{
		GUI.Label (new Rect(10, 10, 100, 30), "Score:\t" + playerScore );
		GUI.Label (new Rect(10, 30, 1000, 30), "Distance:\t" +(int) playerDistance + " M" );
	}
}