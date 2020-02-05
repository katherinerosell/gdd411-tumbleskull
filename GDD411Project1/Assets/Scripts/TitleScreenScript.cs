using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenScript : MonoBehaviour {

    public Button play;
	// Use this for initialization
	void Start () {
        play = play.GetComponent<Button>();
        play.onClick.AddListener(PlayNow);
	}

    void PlayNow() {
        SceneManager.LoadScene(1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
