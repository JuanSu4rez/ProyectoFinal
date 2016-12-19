using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour {

	float[] posX ;
	int countAsteroids;
	float timeInterval = 0.5f;
	int i = 0;

	int typeAsteroid;

	GameObject asteroid;

	public AsteroidType AsteroidType;
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


		// Crear proceso para Asignar el tipo de asteroide
		//		if (typeAsteroid == 1){
		//			AsteroidType == AsteroidType.Small;
		//		}
		//		else if (typeAsteroid == 2){			
		//		AsteroidType == AsteroidType.Medium;
		//			
		//		}
		//		else {
		//		AsteroidType == AsteroidType.Large
		//}

		// Condiguracion de la Dimension del efecto de la explosion 
		//		float emissionRate = 0f;
		//
		//		if (AsteroidType == AsteroidType.Large){
		//			emissionRate = 100f;
		//		}
		//		else if (AsteroidType == AsteroidType.Medium){
		//			emissionRate = 70f;
		//		}
		//		else {
		//
		//			emissionRate = 30f;
		//		}

		// Explosion.GetComponents<ParticleSystem> ().emissionRate = emissionRate;

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


public enum AsteroidType

{ 
	Small,
	Medium,
	Large
}