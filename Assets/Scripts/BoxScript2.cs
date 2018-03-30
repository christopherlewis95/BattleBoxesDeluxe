using UnityEngine;
using System.Collections;

public class BoxScript2 : MonoBehaviour {

	//public Sprite bullet;

	[HideInInspector] public bool facingRight = false;
	[HideInInspector] public bool jump = false;
	public float moveForce = .003f;
	public float maxSpeed = .003f;
	public float jumpForce = .002f;
	public float slamForce = .002f;
	//public Transform groundCheck;
	public Transform firePoint;
	public GameObject bullet;
	// public RectTransform oppHealth;


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
		HealthScript health;



		if (Input.GetKey ("joystick 2 button 7") || 
			Input.GetKey ("j" )) {
				if (rb2d.velocity.x != maxSpeed)
					rb2d.AddForce (Vector2.left * moveForce);


				if (facingRight) {
					Flip ();
					//firePoint.Rotate (0, 180, 0);
				}
				// print("up arrow key is held down");
		} else if (Input.GetKey ("joystick 2 button 8") || 
			Input.GetKey ("l" )) {

				if (rb2d.velocity.x != maxSpeed)
					rb2d.AddForce (Vector2.right * moveForce);


				if (!facingRight) {
					Flip ();
					//firePoint.Rotate (0, 180, 0);
				}
				// print("down arrow key is held down");
		} else if (Input.GetKey ("joystick 2 button 16") || 
			Input.GetKey ("i" )) {

				if (rb2d.velocity.y != maxSpeed)
					rb2d.AddForce (Vector2.up * jumpForce);
				// print("down arrow key is held down");
		} else if (Input.GetKey ("joystick 2 button 6") || 
			Input.GetKey ("k" )) {

				if (rb2d.velocity.y != maxSpeed)
					rb2d.AddForce (Vector2.down * jumpForce);
				// print("down arrow key is held down");
		} else if (Input.GetKeyDown ("joystick 2 button 18") || 
			Input.GetKeyDown ("u" ) || 
			Input.GetKeyDown ("o" )) {

					Instantiate (bullet, firePoint.position, firePoint.rotation);




			}
		



	}


	void FixedUpdate()
	{



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