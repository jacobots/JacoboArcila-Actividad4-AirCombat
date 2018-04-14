using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Destroy (this.gameObject, 5);
		
	}
	
	// Update is called once per frame
	void Update () {


		this.transform.Translate (0.0f, 0.0f, 5.0f);
	}


	void OnCollisionEnter(Collision collision) {

		Destroy (collision.collider.gameObject);

		GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Explosion") as GameObject);
		explosion.transform.position = collision.collider.gameObject.transform.position;


		Destroy (this.gameObject);
	
	}




}
