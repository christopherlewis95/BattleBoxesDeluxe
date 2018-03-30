﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {


	public int currentHealth;
	public Slider healthSlider;
	public int startingHealth = 100;
	//public BulletScript bullet;


	bool isDead;
	bool damaged;

	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {

		if (isDead) {


		}


	}

	public void takeDamage(int amount)
	{
		currentHealth -= amount;
		healthSlider.value = currentHealth;

		if (currentHealth <= 0 && !isDead) {

			death ();
		}
	}


	void death ()
	{
		isDead = true;


	}
}
