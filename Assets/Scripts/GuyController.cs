﻿using UnityEngine;
using System.Collections;

public class GuyController : MonoBehaviour
{

	public float maxSpeed = .4f;
	bool facingRight = true;

	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;
	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();

	}

	void Update ()
	{

		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("ground", false);
			rigidbody2D.AddForce (new Vector2 (0, jumpForce));
		}

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("ground", grounded);

		anim.SetFloat ("vSpeed", rigidbody2D.velocity.y);
		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("speed", Mathf.Abs (move));

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}
	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}
}
