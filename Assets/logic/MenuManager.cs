using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public SpriteRenderer OnePlayer;
    public SpriteRenderer TwoPlayers;

    private int selected;

	void Start () {
        OnePlayer.enabled = true;
        TwoPlayers.enabled = false;
        selected = 0;
	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            selected = selected - 1;
            if (selected < 0)
                selected = 1;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            selected = (selected + 1) % 2;

        else if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
            switch (selected) {
                case 0:
                    Manager.ai = true;
                    SceneManager.LoadScene("gameScene");
                    break;
                case 1:
                    Manager.ai = false;
                    SceneManager.LoadScene("gameScene");
                    break;
            }
        }

        switch (selected) {
            case 0:
                OnePlayer.enabled = true;
                TwoPlayers.enabled = false;
                break;
            case 1:
                OnePlayer.enabled = false;
                TwoPlayers.enabled = true;
                break;
        }
	}
}
