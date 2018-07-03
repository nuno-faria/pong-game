using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour {

    public int Speed = 15;
    public Rigidbody2D rb;

    public AudioClip hitClip;
    private AudioSource audioS;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        audioS = GetComponent<AudioSource>();
        ResetBall();
        Invoke("Go", 0.6f);
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Player") {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + collision.collider.GetComponent<Rigidbody2D>().velocity.y / 2);
            audioS.clip = hitClip;
            audioS.Play();
        }
        else if (collision.collider.name == "leftWall" || collision.collider.name == "rightWall") {
            Manager.Score(collision.collider.name);
            ResetBall();
            Invoke("Go", 0.35f);
        }
    }

    private void ResetBall() {
        rb.position = new Vector2(0, 0);
        rb.velocity = new Vector2(0, 0);
    }

    private void Go() {
        float r = Random.Range(0f, 1f);
        if (r <= 0.5)
            rb.AddForce(new Vector2(80, 10));
        else
            rb.AddForce(new Vector2(-80, 10));
    }
}
