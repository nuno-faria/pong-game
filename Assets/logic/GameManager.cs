using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GUISkin skin;
    public Text pausedText;
    public SpriteRenderer pausedBG;
    public Transform ballPrefab;

    public Text scoreP1;
    public Text scoreP2;

    private bool paused = false;

    void Start() {
        if (Manager.twoBalls)
            Instantiate(ballPrefab);
    }

    private void OnGUI() {
        scoreP1.text = Manager.player1Score.ToString();
        scoreP2.text = Manager.player2Score.ToString();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            Time.timeScale = 1;
            SceneManager.LoadScene("menuScene");
        }

        else if (Input.GetKeyDown(KeyCode.P)) {
            if (!paused) {
                Time.timeScale = 0;
                pausedBG.enabled = true;
                pausedText.enabled = true;
                paused = true;
            }
            else {
                pausedBG.enabled = false;
                pausedText.enabled = false;
                paused = false;
                Time.timeScale = 1;
            }
        }
    }
}
