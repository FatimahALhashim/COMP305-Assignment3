using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/* 
 * Source file name: Youtube Video (COMP305 - W2016 - )
Author's name: Fatimah 
Last Modified by: Fatimah Alhashim
Date last Modified: MARCH29, 2016
Program Description: Simple collect coins game level1 where you can collect coins when you go oveer the platForm
*/
public class GameController : MonoBehaviour {
	//private variables
	private int scoreValue; 
	private int livesValue; 

	private Vector3 playerSpawnPoint;

	//access methods 
	public int ScoreValue {
		get { 
			return scoreValue;
		}
		set { 
			scoreValue = value; 
			ScoreLabel.text = "Score: " + scoreValue;
		}
	}
	public int LivesValue {
		get { 
			return livesValue;
		}
		set { 
			livesValue = value; 
			if (livesValue <= 0) {
				endGame ();
			} else {
				LivesLabel.text = "Lives " + LivesValue;
			}
		}
	
	}

	//public variables 


	public Text LivesLabel; 
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text HighScoreLabel;
	public Button RestartButton;
	public GameObject player;

	// Use this for intialization 
	void Start (){
		initialize ();
		Instantiate (player, playerSpawnPoint, Quaternion.identity);
	}
	private void initialize(){
		playerSpawnPoint = new Vector3 (-11f, 1.6f, 43f);
		ScoreValue = 0; 
		LivesValue = 5; 
		GameOverLabel.gameObject.SetActive (false); 
		HighScoreLabel.gameObject.SetActive (false);
		RestartButton.gameObject.SetActive (false);

	}
		//private methodes
		private void endGame(){
			GameOverLabel.gameObject.SetActive(true);
			LivesLabel.gameObject.SetActive(false); 
			ScoreLabel.gameObject.SetActive(false); 
			HighScoreLabel.gameObject.SetActive(true); 
			RestartButton.gameObject.SetActive(true); 
			HighScoreLabel.text = "High Score" + scoreValue;
		}

	// public methods 
		public void RestartButtonClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
				
	}
			


