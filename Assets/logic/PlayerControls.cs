using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	private Rigidbody2D rb;

    public Rigidbody2D ball;

	public KeyCode Up;
	public KeyCode Down;
	public float Speed = 10;
	

	void Start(){
		rb = GetComponent<Rigidbody2D>();
	}

	void Update () {
        if (rb.name == "Player2" && Manager.ai) {
            Ai();
        }
        else {
            if (Input.GetKey(Up))
                rb.velocity = new Vector2(0, Speed);
            else if (Input.GetKey(Down))
                rb.velocity = new Vector2(0, -Speed);
            else
                rb.velocity = new Vector2(0, 0);
        }
	}

    //very simple ai (only follows ball y pos)
    public void Ai() {
        if (ball.position.y > rb.position.y + 1)
            rb.velocity = new Vector2(0, Speed);
        else if (ball.position.y < rb.position.y - 1)
            rb.velocity = new Vector2(0, -Speed);
    }
}
