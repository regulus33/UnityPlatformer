using UnityEngine;
using System.Collections;

public class GameHandler : MonoBehaviour {

	public float health = 2;
	public float score = 0;
	public bool gameover = false;

	public UnityEngine.UI.Text healthUI;
	public UnityEngine.UI.Text ScoreUI;

	public GameObject youWinUI;
	public GameObject gameOverUI;



	// Use this for initialization
	void Start () {

		healthUI.text = health.ToString ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D c) {
		if (c.tag == "Coin") {
			
			AddScore (); 
			Destroy (c.gameObject);

		} else if (c.tag == "Water") {
			
			health = 0;
			healthUI.text = health.ToString ();	
			gameOverUI.SetActive (true);
			StopGame ();


		} else if ( c.tag == "Ending" ) {
			youWinUI.SetActive (true);
			StopGame ();
		}
	}

	public void SubtractHealth() {
		health -= 1;
		healthUI.text = health.ToString ();
		if (health == 0) {
			gameOverUI.SetActive (true);
			StopGame ();
		}

	}

	public void AddScore() {
		score += 10;
		ScoreUI.text = score.ToString();
	}

	public void StopGame() {
		gameover = true;
		gameObject.SetActive(false);
	}

}
