using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public SpriteRenderer OnePlayer;
    public SpriteRenderer TwoPlayers;
    public SpriteRenderer TwoPlayersTwoBalls;

    private int selected;

	void Start () {
        OnePlayer.enabled = true;
        TwoPlayers.enabled = false;
        selected = 0;
	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            selected = selected - 1;
            if (selected < 0)
                selected = 2;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            selected = (selected + 1) % 3;

        else if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
            switch (selected) {
                case 0:
                    Manager.ai = true;
                    Manager.twoBalls = false;
                    SceneManager.LoadScene("gameScene");
                    break;
                case 1:
                    Manager.ai = false;
                    Manager.twoBalls = false;
                    SceneManager.LoadScene("gameScene");
                    break;
                case 2:
                    Manager.ai = false;
                    Manager.twoBalls = true;
                    SceneManager.LoadScene("gameScene");
                    break;

            }
        }

        switch (selected) {
            case 0:
                OnePlayer.enabled = true;
                TwoPlayers.enabled = false;
                TwoPlayersTwoBalls.enabled = false;
                break;
            case 1:
                OnePlayer.enabled = false;
                TwoPlayers.enabled = true;
                TwoPlayersTwoBalls.enabled = false;
                break;
            case 2:
                OnePlayer.enabled = false;
                TwoPlayers.enabled = false;
                TwoPlayersTwoBalls.enabled = true;
                break;
        }
	}
}
