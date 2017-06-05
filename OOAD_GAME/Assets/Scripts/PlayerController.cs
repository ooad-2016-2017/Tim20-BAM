using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Camera kamera;

	private float maxSirina;

	// Use this for initialization
	void Start () {
		if (kamera == null) {
			kamera = Camera.main;
		}
		Vector3 gornjiUgao = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 ciljna_sirina = kamera.ScreenToWorldPoint (gornjiUgao);
		Renderer renderer = GetComponent<Renderer> ();
		float player_sirina = renderer.bounds.extents.x;
		maxSirina = ciljna_sirina.x - player_sirina;
	}
	void FixedUpdate () {
		Vector3 pocetna_pozicija = kamera.ScreenToWorldPoint (Input.mousePosition);
		Vector3 ciljna_pozicija = new Vector3 (pocetna_pozicija.x, 0.0f, 0.0f);
		float ciljna_sirina = Mathf.Clamp (ciljna_pozicija.x, -maxSirina, maxSirina);
		ciljna_pozicija = new Vector3 (ciljna_sirina, ciljna_pozicija.y, ciljna_pozicija.z);
		Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D> ();
		rigidbody2D.MovePosition (ciljna_pozicija);
	}
}
