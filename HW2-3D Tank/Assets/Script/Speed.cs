using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision){	


		if (collision.collider.gameObject.name == "TankGreen") {
			gameObject.SetActive (false);
			moveGreenTank.speed += 10;
		}
		if (collision.collider.gameObject.name == "Tank_pref") {
			gameObject.SetActive (false);
			moveGreenTank.speed += 10;
		}

	}
}
