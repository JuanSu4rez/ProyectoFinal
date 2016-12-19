using UnityEngine;
using System.Collections;

public class ShotAsteroid : MonoBehaviour {

	float speed;

	Collider collider;
	MeshRenderer mesh;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {		
		gameObject.transform.Translate (new Vector3 (0f, 0f, -speed));
		transform.Rotate (Vector3.forward, speed*10);
	}

	void setSpeed(float paramSpeed)	{
		speed = paramSpeed;
	}
}
