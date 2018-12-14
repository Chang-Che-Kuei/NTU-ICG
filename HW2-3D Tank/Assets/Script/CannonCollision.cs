using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CannonCollision : MonoBehaviour {
	public Image healthBar_MassiveTank;
	public Image healthBar_GreenTank;
	public GameObject explsion;
	public Text gameover;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision){	


		if (collision.collider.gameObject.name == "TankGreen") {
			Debug.Log ("touch green");
			healthBar_GreenTank.fillAmount -= 0.1f;
			if (healthBar_GreenTank.fillAmount <= 0) {
				gameover.text = "Massive Tank Wins";
                GameObject enemy = GameObject.Find("TankGreen");
                enemy.active = false;
            }
         
        }
		if (collision.collider.gameObject.name == "Tank_pref") {
			Debug.Log ("touch Massive");
			healthBar_MassiveTank.fillAmount -= 0.1f;
			if (healthBar_MassiveTank.fillAmount <= 0) {
				gameover.text = "Green Tank Wins";
                GameObject playerTank = GameObject.Find("Tank_pref");
                playerTank.active = false;
            }
		}
		GameObject exp = Instantiate (explsion, transform.position, transform.rotation)as GameObject;
		Destroy (exp, 1);
        Destroy(this.gameObject);
	}
}
