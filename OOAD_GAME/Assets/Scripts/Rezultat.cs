﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rezultat : MonoBehaviour {

	public Text rezultat_text;
	public int ticketValue;

	public GameControllerScript GC;
	private int rezultat;

	void Start () {
		rezultat = 0;
		UpadateRezultat ();
	}

	void FixedUpdate(){
		if(GC.preostalo_vrijeme == 0)
			UpadateRezultat ();
	}

	void OnTriggerEnter2D (){
		rezultat += ticketValue;
		UpadateRezultat ();
	}
	void UpadateRezultat(){
		rezultat_text.text = "Rezultat: " + rezultat;
	}
}
