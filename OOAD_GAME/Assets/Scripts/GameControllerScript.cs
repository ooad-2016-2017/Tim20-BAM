using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {

	public Camera kamera;
	public GameObject ticket;
	public float preostalo_vrijeme;
	public Text brojac_tekst;
	public GameObject kraj_igre_tekst;
	public GameObject restartDugme;

	private float maxSirina;

	// Use this for initialization
	void Start () {
		if (kamera == null) {
			kamera = Camera.main;
		}
		Vector3 gornjiUgao = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 ciljna_sirina = kamera.ScreenToWorldPoint (gornjiUgao);
		float ticket_sirina = ticket.GetComponent<Renderer> ().bounds.extents.x;
		maxSirina = ciljna_sirina.x - ticket_sirina;
		StartCoroutine (Spawn ());
		UpdateText ();
	}

	void FixedUpdate(){
		preostalo_vrijeme -= Time.deltaTime;
		if(preostalo_vrijeme < 0)
			preostalo_vrijeme = 0;
		UpdateText();
	}

	IEnumerator Spawn () {
		yield return new WaitForSeconds (2.0f);
		while (preostalo_vrijeme > 0) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-maxSirina, maxSirina), transform.position.y, 0.0f);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (ticket, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range(1.0f, 2.0f));
		}
		yield return new WaitForSeconds (1.0f);
		kraj_igre_tekst.SetActive (true);
		yield return new WaitForSeconds (2.0f);
		restartDugme.SetActive (true);
	}

	void UpdateText(){
		brojac_tekst.text = "Prestalo vrijeme: " + Mathf.RoundToInt (preostalo_vrijeme);
	}
}
