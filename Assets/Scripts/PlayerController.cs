using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	//private variables
	private Transform transform;
	private GameController gameController;


	// Use this for initialization
	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		gameController = GameObject.FindWithTag ("GameController").GetComponent("GameController") as GameController;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggereEnter(Collider other){
		//reset the player to spawn point 
		if(other.gameObject.CompareTag("Coin")){
				gameController.ScoreValue += 10;
			}
		if (other.gameObject.CompareTag ("Wood")){
			gameController.LivesValue -= 1;}

		}
		
		}
		

	




