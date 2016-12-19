using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speedquad = 0.5f;
	public float speedquad2 = 0.5f;

	GameObject quad;
	GameObject quadlvl2;

	AudioSource explosionSound; 

	// Use this for initialization
	void Start () {

		quad = transform.FindChild ("Quad1").gameObject;
		quadlvl2 = transform.FindChild ("Quad2").gameObject;

		explosionSound = gameObject.transform.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 movement = new Vector2 (0, speedquad*Time.time);
		quad.GetComponent<Renderer> ().material.mainTextureOffset = movement;

		Vector2 movement2 = new Vector2 (0, speedquad2*Time.time);
		quadlvl2.GetComponent<Renderer> ().material.mainTextureOffset = movement2;
	}

	/*
	void OnCollisionEnter(Collision other) {
		Debug.Log("ENTRANDOOOOOOOOOOOOOOO");		
	}*/

	//Todo objeto que salga del collider se destruye
	void OnTriggerExit(Collider other) {		
			Destroy(other.gameObject);
	}

	void destroyOmega()
	{
		explosionSound.Play ();
	}
}
