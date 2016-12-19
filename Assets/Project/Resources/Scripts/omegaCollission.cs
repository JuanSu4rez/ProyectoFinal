using UnityEngine;
using System.Collections;

public class omegaCollission : MonoBehaviour {
	
	GameObject boxCollider;


	// Use this for initialization
	void Start () {	
		boxCollider = GameObject.Find ("BackGround");
	}
	
	// Update is called once per frame
	void Update () {	

	}

	void OnCollisionEnter(Collision other) {
		//ignorar colisiones contra BoxCollider
		if (!other.gameObject.name.Equals("BackGround")) 
		{
			Debug.Log ("OnCollisionEnter");
			//if (other.gameObject.name.Equals("Stone_1")) {
				DestroyOmegaParent ();

			//}
		}
	}

	void OnTriggerEnter(Collider other) {
		//ignorar colisiones contra BoxCollider
		if (!other.gameObject.name.Equals("BackGround")) 
		{	
			//Si la colision es contra un asteroide, destruirlo junto con el avion
			if (other.gameObject.name.Contains("Stone")) {
				Destroy (other.gameObject);
				DestroyOmegaParent ();

			}
		}
	}

	void DestroyOmegaParent ()
	{
		boxCollider.SendMessage ("destroyOmega");
		Destroy (gameObject.transform.parent.parent.gameObject);
	}
}
