using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speedquad = 0.5f;
	public float speedquad2 = 0.5f;

	GameObject quad;
	GameObject quadlvl2;

	// Use this for initialization
	void Start () {

		quad = transform.FindChild ("Quad1").gameObject;
		quadlvl2 = transform.FindChild ("Quad2").gameObject;
		//Debug.Log (quad.name);

		//gameObject.AddComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 movement = new Vector2 (0, speedquad*Time.time);
		quad.GetComponent<Renderer> ().material.mainTextureOffset = movement;

		Vector2 movement2 = new Vector2 (0, speedquad2*Time.time);
		quadlvl2.GetComponent<Renderer> ().material.mainTextureOffset = movement2;

		//gameObject.GetComponent<Renderer> ().material.mainTextureOffset = movement;
	}
}
