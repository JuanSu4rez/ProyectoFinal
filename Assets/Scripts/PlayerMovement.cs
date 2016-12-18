using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	float movementSpeed = 0;
	public float health;

	public float limitPosZ;
	public float limitNegZ;
	public float limitPosX;
	public float limitNegX;
	float postemp;

	//particulas
	GameObject flare;

	//Disparo
	GameObject shot;
	GameObject shotOrigin;

	// Use this for initialization
	void Start () {
		movementSpeed = 0.1f;

		limitPosZ = 5f;
		limitNegZ = -8f;
		limitPosX = 4.35f;
		limitNegX = -4.35f;	

		flare = gameObject.transform.FindChild ("Flare").gameObject;
		shotOrigin = gameObject.transform.FindChild ("ShotOrigin").gameObject;
	}
	
	// Update is called once per frame
	void Update () {

		//limites horizontales -4.35, 4.35
		//limites verticales -9, 5
		if(Input.GetKey("up"))
		{
			postemp = gameObject.transform.position.z + movementSpeed;
			if (postemp < limitPosZ) 
				gameObject.transform.Translate(0f, 0f, movementSpeed);
		}
		if(Input.GetKey("down"))
		{
			postemp = gameObject.transform.position.z - movementSpeed;
			if (postemp > limitNegZ) 
				gameObject.transform.Translate(0f, 0f, -movementSpeed);
		}
		if(Input.GetKey("left"))
		{
			postemp = gameObject.transform.position.x - movementSpeed;
			if (postemp > limitNegX) 
				gameObject.transform.Translate(-movementSpeed, 0f, 0f);
		}
		if(Input.GetKey("right"))
		{
			postemp = gameObject.transform.position.x + movementSpeed;
			if (postemp < limitPosX) 
				gameObject.transform.Translate(movementSpeed, 0f, 0f);
		}
		if(Input.GetKey("space"))
		{
			//Debug.Log("Disparando");   			
			Instantiate (Resources.Load ("Prefabs/Shot"), shotOrigin.transform.position, Quaternion.identity);

			//Instantiate (shot, shotOrigin.transform.position, shotOrigin.transform.rotation);
		}


		//Reescalado de la flama en funcion de la aceleracion
		if (Input.GetKeyDown("up")) {
			flare.transform.localScale = Vector3.one*1.5f; 
		}
		if (Input.GetKeyUp("up")) {
			flare.transform.localScale = Vector3.one; 			
		}
		if (Input.GetKeyDown("down")) {
			flare.transform.localScale = Vector3.one*0.5f; 
		}
		if (Input.GetKeyUp("down")) {
			flare.transform.localScale = Vector3.one; 
		}

	}

	void OnCollisionEnter(Collision other) {
		Debug.Log("COLLISION DESDES MALLA DEL AVION");		
	}






}
