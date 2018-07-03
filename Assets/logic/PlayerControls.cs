using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	private Rigidbody2D rb;

	public KeyCode Up;
	public KeyCode Down;
	public float Speed = 10;
	

	void Start(){
		rb = GetComponent<Rigidbody2D>();
	}

	void Update () {
        System.Console.WriteLine("asdasdasd");
        if (Input.GetKey(Up))
			rb.velocity = new Vector2(0, Speed);
        else if (Input.GetKey(Down))
            rb.velocity = new Vector2(0, -Speed);
		else
			rb.velocity = new Vector2(0,0);
	}
}
