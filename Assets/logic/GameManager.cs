using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GUISkin skin;

    private void OnGUI() {
        GUI.skin = skin;
        GUI.Label(new Rect(Screen.width / 2 - 100 - 16, 20, 100, 100), Manager.player1Score.ToString());
        GUI.Label(new Rect(Screen.width / 2 + 100 - 16, 20, 100, 100), Manager.player2Score.ToString());
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q))
            SceneManager.LoadScene("menuScene");
    }
}
