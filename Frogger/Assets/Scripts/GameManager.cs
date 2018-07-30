using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int life;
	public Text lifeText;
	public int goals;
	public Text goalText;
	public Text winText;

	public GameObject menu;

	// Use this for initialization
	void Start () {
		lifeText.text = "Lives: " + life;
		goalText.text = "Goals: " + goals;
	}

	// Update is called once per frame
	void Update () {
		lifeText.text = "Lives: " + life;
		goalText.text = "Goals: " + goals;

		if (life < 1) {
			GameOver ();
		}

		if (goals < 1) {
			YouWin ();
		}
	}

	void GameOver(){
		winText.text = "You lose!!";
		SceneManager.LoadScene ("Level1");
	}

	void YouWin (){
		winText.text = "Victory!!";
		Application.Quit ();
	}
}
