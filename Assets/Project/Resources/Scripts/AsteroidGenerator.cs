using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour {

	float[] posX ;
	int countAsteroids;
	float timeInterval = 0.5f;
	int i = 0;

	int typeAsteroid;

	GameObject asteroid;


	public GameObject Explosion;

	// Use this for initialization
	void Start () {

		posX = new float[]{-3.5f, -2.5f, -1.5f, -0.5f, 1.5f, 2.5f, 3.5f};
		InvokeRepeating ("CreateAsteroid", 0f, timeInterval);

		//asteroid.transform.GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, 0f, -0.1f));

	}

	// Update is called once per frame
	void Update () {
		
	}

	void CreateAsteroid(){

		typeAsteroid = Random.Range (1, 4);




		float asteroidPosX = posX [i];
		Vector3 asteroidVecPos = new Vector3 (asteroidPosX, gameObject.transform.position.y, gameObject.transform.position.z);

		Vector3 asteroidRotation = new Vector3(0f, Random.Range (0f, 360f), 0f);
		asteroid = (GameObject)Instantiate(Resources.Load ("Prefabs/Stone_" + (int)typeAsteroid), 
			asteroidVecPos, 
			gameObject.transform.rotation);

		if (typeAsteroid != 3) {
			asteroid.gameObject.transform.localScale = Vector3.one*1.4f;				
		}


		//asteroid = (GameObject)Instantiate(Resources.Load ("Prefabs/Stone_" + (int)typeAsteroid), gameObject.transform.position, gameObject.transform.rotation);
		float speed = Random.Range (0.1f, 0.3f);
		asteroid.SendMessage ("setSpeed", speed);

		//recorrido del arreglo de las posiciones para generar los asteroides
		i++;
		if (i == 5) 
			i = 0;
	}
}


