using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour {

    public int Speed = 12;
    public Rigidbody2D rb;

    public AudioClip hitClip;
    private AudioSource audioS;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        audioS = GetComponent<AudioSource>();
        ResetBall();
        Invoke("Go", 0.8f);
	}

    private float intervalAbs(float min, float value, float max) {
        if (Math.Abs(value) < min)
            return min * Math.Sign(value);
        if (Math.Abs(value) > max)
            return max * Math.Sign(value);
        else return value;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Player") {
            rb.velocity = new Vector2(rb.velocity.x, intervalAbs(5,rb.velocity.y + collision.collider.GetComponent<Rigidbody2D>().velocity.y / 2.5f,20));
            Debug.Log(rb.velocity);
            audioS.clip = hitClip;
            audioS.Play();
        }
        else if (collision.collider.name == "leftWall" || collision.collider.name == "rightWall") {
            Manager.Score(collision.collider.name);
            ResetBall();
            Invoke("Go", 0.5f);
        }
    }

    private void ResetBall() {
        rb.position = new Vector2(0, 0);
        rb.velocity = new Vector2(0, 0);
    }

    private void Go() {
        float r = UnityEngine.Random.Range(0f, 1f);
        if (r <= 0.5)
            rb.AddForce(new Vector2(80, 10));
        else
            rb.AddForce(new Vector2(-80, 10));
    }
}
