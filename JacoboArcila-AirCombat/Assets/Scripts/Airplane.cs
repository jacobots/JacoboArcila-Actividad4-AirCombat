using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (0.0f, 0.0f, 0.8f);



		// Si la trecla espacio, es precionada:

		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 2.0f, 0.0f);

		}


		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -2.0f, 0.0f);

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-2.0f, 0.0f, 0.0f);
		
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (2.0f, 0.0f, 0.0f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			// Reconstruyo un gameObject a partir
			// de la información guardada en un prefab
			GameObject misil = GameObject.Instantiate (Resources.Load ("Prefabs/Misil") as GameObject);
		

			// Hago que el misisl sea hijo del avión.
			misil.transform.SetParent (this.gameObject.transform);

			// Muevo el misil a unas coordenadas relativas con respecto al pivote del avión.
			misil.transform.localPosition = new Vector3 (120.72f, 0.16f, -4.32f);

			// Saco al misil del avión.
			misil.transform.SetParent (null);



		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			// Reconstruyo un gameObject a partir
			// de la información guardada en un prefab
			GameObject misil = GameObject.Instantiate (Resources.Load ("Prefabs/Misil 2") as GameObject);


			// Hago que el misisl sea hijo del avión.
			misil.transform.SetParent (this.gameObject.transform);

			// Muevo el misil a unas coordenadas relativas con respecto al pivote del avión.
			misil.transform.localPosition = new Vector3 (112.12f, 0.16f, -4.32f);

			// Saco al misil del avión.
			misil.transform.SetParent (null);



		}


	



	}
}
