using UnityEngine;
using System.Collections;

public class ShotBehaviour : MonoBehaviour {

	public float speedShot;
	public GameObject BoxCollider;

	// Use this for initialization
	void Start () {
		speedShot = 1;
		BoxCollider = GameObject.Find("BackGround").gameObject;
	}

	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(0f, 0f, speedShot);
	}	

	//Validar el tipo de enemigo que se impacta
	void OnCollisionEnter(Collision other) 
	{
		if (!other.gameObject.name.Equals("BackGround")) 
		{			
			if (other.gameObject.name.Contains("Stone")) 
			{		
				if (other.gameObject.name.Contains("1")) {					
					BoxCollider.SendMessage ("DestroyAsteroid1",  other.gameObject.transform.position);
				}
				else if(other.gameObject.name.Contains("2")){
					BoxCollider.SendMessage ("DestroyAsteroid2",  other.gameObject.transform.position);
				}
				else {
					BoxCollider.SendMessage ("DestroyAsteroid3",  other.gameObject.transform.position);
				}
				Destroy (other.gameObject);
			}
			Destroy (gameObject);	
		}
	}


}
