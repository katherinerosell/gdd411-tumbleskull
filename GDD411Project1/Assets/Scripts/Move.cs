using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

    private Rigidbody playerRB;
    public Image gameOverUI;
    public Text gameOverText;
    public Text finalScore;
    public Button restart;
    public Button home;
    public Text currentScore;
    //private Score scoreScript;

	// Use this for initialization
	void Start () {
        playerRB = GetComponent<Rigidbody>();
        gameOverUI = gameOverUI.GetComponent<Image>();
        gameOverText = gameOverText.GetComponent<Text>();
        finalScore = finalScore.GetComponent<Text>();
        currentScore = currentScore.GetComponent<Text>();
        restart = restart.GetComponent<Button>();
        home = home.GetComponent<Button>();

        //hide game over section at first
        gameOverUI.enabled = false;
        gameOverText.enabled = false;
        finalScore.enabled = false;
        //currentScore.enabled = false;
        restart.gameObject.SetActive(false);
        home.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        playerRB.AddForce(Input.acceleration.x * 50, 0f, (Input.acceleration.y + 0.4f) * 130);
    }


    private void OnCollisionEnter(Collision collision)  {
        if (collision.gameObject.tag == "TumbleWeed") {
            Debug.Log("Tumble Weed Hit Player!!");
            //destroy player
            //display UI screen with final score
            //ask player to restart 
            //or go to home screen
            Destroy(playerRB.gameObject);
            gameOverUI.enabled = true;
            gameOverText.enabled = true;
            finalScore.enabled = true;
            home.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);

            finalScore.text = "Final Score: " + Score.scoreNum;
            currentScore.enabled = false;
        }


    }

}
