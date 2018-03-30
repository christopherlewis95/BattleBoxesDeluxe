using UnityEngine;
using System.Collections;

public class StickControl : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool facingLeft = true;
	[HideInInspector] public bool jump = false;
	public float moveForce = .005f;
	public float maxSpeed = .0010f;
	public float jumpForce;
	public Transform groundCheck;


	private bool grounded = false;
	private Animator anim;
	private Rigidbody2D rb2d;


	// Use this for initialization
	void Awake () 
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame


	/*
	var r2d = GetComponent("Rigidbody2D");
	if (Input.GetKey("right"))
		r2d.velocity.x = 10;
	else if (Input.GetKey("left"))
		r2d.velocity.x = -10;
	else
		r2d.velocity.x = 0;

	// When the spacebar is pressed
	if (Input.GetKeyDown("space")) {
		// Create a new bullet at “transform.position” 
		// Which is the current position of the ship
		// Quaternion.identity = add the bullet with no rotation
		Instantiate(bullet, transform.position, Quaternion.identity);
	*/






	void Update () 
	{

	}

	void FixedUpdate()
	{
		float h = Input.GetAxis("Horizontal");

		if (Input.GetKey ("left")) {

			if (h > 0 && !facingRight)
				Flip ();
			else if (h < 0 && facingRight)
				Flip ();
			
			if( rb2d.velocity.x != maxSpeed )
				rb2d.AddForce(Vector2.left * moveForce);
			// print("up arrow key is held down");
		}


		else if (Input.GetKey ("right")) {
			
			if (h > 0 && !facingRight)
				Flip ();
			else if (h < 0 && facingRight)
				Flip ();
			
			if( rb2d.velocity.x != maxSpeed )
				rb2d.AddForce (Vector2.right * moveForce);
			// print("down arrow key is held down");
		}

		else if (Input.GetKey ("space")) {

			if( rb2d.velocity.y != maxSpeed )
				rb2d.AddForce (Vector2.up * jumpForce);
			// print("down arrow key is held down");
		}


		/*
		anim.SetFloat("Speed", Mathf.Abs(h));

		if (h * rb2d.velocity.x < maxSpeed)
			rb2d.AddForce(Vector2.right * h * moveForce);

		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
			rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

		if (h > 0 && !facingRight)
			Flip ();
		else if (h < 0 && facingRight)
			Flip ();

		if (jump)
		{
			anim.SetTrigger("Jump");
			rb2d.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
		*/
	}


	void Flip()
	{
		facingRight = !facingRight;
		Vector2 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}