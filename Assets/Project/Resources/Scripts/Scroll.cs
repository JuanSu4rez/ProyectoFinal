using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scroll : MonoBehaviour {

	Text textAttempts;
	Text textAsteroidsCounter;

	Image bossBar;
	int bossHealth = 100;

	int AsteroidsCounter = 0;
	int attempts = 3;
	public float speedquad = 0.5f;
	public float speedquad2 = 0.5f;

	GameObject quad;
	GameObject quadlvl2;

	GameObject player;
	GameObject boss;

	AudioSource explosionSound;  

	// Use this for initialization
	void Start () {


		player = GameObject.Find ("OmegaParent");
		boss = GameObject.Find ("EnemyParent");

		quad = transform.FindChild ("Quad1").gameObject;
		quadlvl2 = transform.FindChild ("Quad2").gameObject;

		explosionSound = gameObject.transform.GetComponent<AudioSource> ();

		textAttempts = GameObject.Find ("Canvas").transform.FindChild ("Attempts").GetComponent<Text> ();
		textAsteroidsCounter = GameObject.Find ("Canvas").transform.FindChild ("AsteroidCounter").GetComponent<Text> ();

		//bossBar = GameObject.Find ("Canvas").transform.FindChild ("Bossbar").GetComponent<Image> ();

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
		GameObject explosion = (GameObject)Instantiate (Resources.Load ("Prefabs/Explosion_player"), player.transform.position, Quaternion.identity);

	}

	void DestroyAsteroid1( Vector3 pos){
		
		AsteroidsCounter++;
		GameObject explosion = (GameObject)Instantiate (Resources.Load ("Prefabs/Explosion_Asteroid2"), pos, Quaternion.identity);
		}

	void DestroyAsteroid2( Vector3 pos){
		
		AsteroidsCounter++;
		GameObject explosion = (GameObject)Instantiate (Resources.Load ("Prefabs/Explosion_Asteroid1"), pos, Quaternion.identity);
		}

	void DestroyAsteroid3( Vector3 pos){
		
		AsteroidsCounter++;
		GameObject explosion = (GameObject)Instantiate (Resources.Load ("Prefabs/Explosion_Asteroid"), pos, Quaternion.identity);
		}
}
