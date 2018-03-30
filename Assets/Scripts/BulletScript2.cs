using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BulletScript2 : MonoBehaviour {

	public BoxScript box;
	public BoxScript2 box2;
	//public HealthScript health1;
	//public HealthScript health2;
	//public GameObject player1;
	//public GameObject player2;
	//public BoxScript box2;
	//public Slider p1Health;
	//public Slider p2Health;
	float speed = 12;
	float speed2 = 8;
	GameObject player1;
	GameObject player2;
	HealthScript player1Health;
	HealthScript player2Health;


	public int velocity = 10;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		box = FindObjectOfType<BoxScript> ();
		box2 = FindObjectOfType<BoxScript2> ();


		player1 = GameObject.FindGameObjectWithTag ("Player1");
		player1Health = player1.GetComponent<HealthScript> ();
		player2 = GameObject.FindGameObjectWithTag ("Player 2");
		player2Health = player2.GetComponent<HealthScript> ();
		//if (box == null) {


		//}

		//if (box2 == null) {

		//}


		//box2 = FindObjectOfType<BoxScript> ();
		rb2d = GetComponent<Rigidbody2D>();
		//collider = GetComponent<BoxCollider2D> ();

		if (box2.transform.localScale.x < 0) {

			speed = -speed;

		}
		//if (player2.transform.localScale.x < 0)
		//	speed = -speed;

	}

	// Update is called once per frame
	void Update () {



		rb2d.velocity = new Vector2 (speed, rb2d.velocity.y);

	}

	void OnTriggerEnter2D(Collider2D other){



		Destroy (gameObject);


		if(other.name == "RTS_Crate (Player 1)")
		{
			print ("COLLISION WITH PL 1");
			player1Health.takeDamage (10);


			if (player1Health.currentHealth <= 0) {

				Destroy (player1);
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}
		}
	}

}

