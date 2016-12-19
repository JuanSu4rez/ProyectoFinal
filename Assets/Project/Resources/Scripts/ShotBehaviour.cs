using UnityEngine;
using System.Collections;

public class ShotBehaviour : MonoBehaviour {

	public float speedShot;
	public GameObject BoxCollider;
	int Puntaje = 0;
	
	// Use this for initialization
	void Start () {
		speedShot = 1;

//		BoxCollider = GameObject.Find("BoxCollider").gameObject;
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
				

				Destroy (other.gameObject);
				Puntaje ++;
				Debug.Log ("El puntaje es:" + Puntaje);

			}
			Destroy (gameObject);	

		}
	}


}
