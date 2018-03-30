using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {

	//public Sprite bullet;

	[HideInInspector] public bool facingRight = true;
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








	void Update ()
	{

		//transform.Rotate(0, x, 0);
		//transform.Translate(0, 0, z);
		HealthScript health;





		if(this.name == "RTS_Crate (Player 1)") {


			if (Input.GetKey ("joystick 1 button 7") || 
				Input.GetKey ("a" )) {
				if (rb2d.velocity.x != maxSpeed)
					rb2d.AddForce (Vector2.left * moveForce);


				if (facingRight) {
					Flip ();
					//firePoint.Rotate (0, 180, 0);
				}
				// print("up arrow key is held down");
			} else if (Input.GetKey ("joystick 1 button 8" ) || 
				Input.GetKey ("d" ) ) {

				if (rb2d.velocity.x != maxSpeed)
					rb2d.AddForce (Vector2.right * moveForce);


				if (!facingRight) {
					Flip ();
					//firePoint.Rotate (0, 180, 0);
				}
				// print("down arrow key is held down");
			} else if (Input.GetKey ("joystick 1 button 16") || 
				Input.GetKey ("w" )) {

				if (rb2d.velocity.y != maxSpeed)
					rb2d.AddForce (Vector2.up * jumpForce);
				// print("down arrow key is held down");
			} else if (Input.GetKey ("joystick 1 button 6") || 
				Input.GetKey ("s" )) {

				if (rb2d.velocity.y != maxSpeed)
					rb2d.AddForce (Vector2.down * jumpForce);
				// print("down arrow key is held down");
			} else if (Input.GetKeyDown ("joystick 1 button 18") || 
				Input.GetKeyDown ("e" ) || 
				Input.GetKeyDown ("q" )) {


		
					Instantiate (bullet, firePoint.position, firePoint.rotation);

				


			}
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