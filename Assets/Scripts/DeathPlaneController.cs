using UnityEngine;
using System.Collections;

public class DeathPlaneController : MonoBehaviour {

	//private variables 
	private AudioSource playerDead;

	//public variable 
	public Transform spawnPoint;
	public GameController gameController; 


	// Use this for initialization
	void Start () {
		playerDead = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggereEnter(Collider other){
		//reset the player to spawn point 
		if(other.gameObject.CompareTag("Player")){
			Debug.Log (spawnPoint.position);
			Transform playerTransform = other.gameObject.GetComponent<Transform> ();
			playerTransform.position = spawnPoint.position;
			gameController.LivesValue -= 1; 
			playerDead.Play ();
		}
		else{
			Destroy (other.gameObject);					
			}

	}
}
