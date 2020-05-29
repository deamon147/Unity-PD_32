using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Balloon : MonoBehaviour {

	private Text ScoreText;

	private void Start () {
		ScoreText = GameManager.gm.GameplayUI.Find ("ScorePlaceholder").Find ("Score").GetComponent<Text> ();
	}
	
	private void Update () {
		ScoreText.text = Mathf.Max (0, Mathf.FloorToInt (transform.position.y)).ToString ();
	}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Obstacle") {
			print ("GAME OVER!");
			SceneManager.LoadScene ("Menu");
;		}
		else if (other.tag == "LevelEnd") {
			other.tag = "Untagged"; 
			GameManager.gm.lm.SpawnLevel ();
		}
	}

}