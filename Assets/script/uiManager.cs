using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {
		public Text scoreText;
		int score;
		public Text highScore;
		int hScore;
		bool gameOver;
		public Button[] buttons;
	// Use this for initialization
	void Start () {
				hScore = PlayerPrefs.GetInt ("HighScore");
				gameOver = false;
				score = 0;
				InvokeRepeating ("scoreUpdate",2.0f,1.0f);

	}
	
	// Update is called once per frame
	void Update () {
				scoreText.text = "Score : " + score;
				highScore.text = "Highscore " + hScore;


	}
		void scoreUpdate(){
				if (gameOver == false) {
						score += 1;
				}
		}
		public void gameOverActivated(){
				if (score >= hScore) {
						hScore = score;
						PlayerPrefs.SetInt ("HighScore", score);
				}
				gameOver = true;
				foreach(Button button in buttons){
						button.gameObject.SetActive(true);
				}
		}
		public void play(){
				SceneManager.LoadScene ("level1");
		}

		public void pause(){
				if (Time.timeScale == 1) {
						Time.timeScale = 0;
				} else if (Time.timeScale == 0) {
						Time.timeScale = 1;
				}
		}
		public void Replay(){
				SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
		public void menu(){
				SceneManager.LoadScene ("menuScene");
		}
		public void exit(){
				Application.Quit();
		}
}
