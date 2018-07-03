using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

    public Camera mainCam = new Camera();

    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player1;
    public Transform player2;

	void Start () {
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 0.25f);
        topWall.offset = new Vector2(0, mainCam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y + 0.6f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 0.25f);
        bottomWall.offset = new Vector2(0, mainCam.ScreenToWorldPoint(new Vector3(0, 0, 0)).y + 0.4f);

        leftWall.size = new Vector2(0.25f, mainCam.ScreenToWorldPoint(new Vector3(0, Screen.height * 2, 0)).y);
        leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 0.2f, 0);

        rightWall.size = new Vector2(0.25f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2, 0)).y);
        rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x - 0.08f, 0);

        player1.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(80, 0, 0)).x, player1.position.y);
        player2.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 80, 0, 0)).x, player1.position.y);
    }
}