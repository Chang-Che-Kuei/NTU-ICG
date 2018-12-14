using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAttack : MonoBehaviour {

	public GameObject dra;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void d_bite(){
		dra.GetComponent<Animation> ().CrossFade ("bite");
		dra.GetComponent<Animation> ().CrossFadeQueued ("idle");
	}


}
