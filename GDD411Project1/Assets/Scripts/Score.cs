using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    float timer = 0.0f;
    public Text score;
    public static int scoreNum;
    public Button restart;
    public Button home;
	// Use this for initialization
	void Start () {
        score = score.GetComponent<Text>();
        home = home.GetComponent<Button>();
        restart = restart.GetComponent<Button>();
        //button on click/touch
        home.onClick.AddListener(GoHome);
        restart.onClick.AddListener(Restart);
        scoreNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        int secondsToScore =(int) timer % 60;
        scoreNum = secondsToScore;
        score.text = "Yee Haw Score: " + secondsToScore.ToString();

	}

    void GoHome() {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }

    void Restart() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

}
