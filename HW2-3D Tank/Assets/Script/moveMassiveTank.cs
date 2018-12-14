using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMassiveTank : MonoBehaviour {

	static public float speed = 50f;

	public GameObject bulletObj;
    public GameObject bombObj;
    public GameObject fireObj;
	public AudioClip fire_sound;
	private AudioSource aud;
	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			this.transform.Translate (speed * Time.deltaTime, 0, 0);
		if (Input.GetKey (KeyCode.S))
			this.transform.Translate (-speed * Time.deltaTime, 0, 0);
		if (Input.GetKey (KeyCode.A))
			this.transform.Rotate (0, -90* Time.deltaTime, 0);
		if(Input.GetKey (KeyCode.D))
			this.transform.Rotate (0, 90* Time.deltaTime, 0);

		if (Input.GetKeyDown (KeyCode.V)) {
			GameObject b = Instantiate (bulletObj, fireObj.transform.position, fireObj.transform.rotation) as GameObject;
			Vector3 dir = transform.TransformDirection(Vector3.right);
			b.GetComponent<Rigidbody> ().velocity = dir * 100;
			//aud.Play ();
		    aud.PlayOneShot (fire_sound);
			Destroy (b, 3);
            
		}

        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject b = Instantiate(bombObj, fireObj.transform.position, fireObj.transform.rotation) as GameObject;
            Vector3 dir = transform.TransformDirection(Vector3.right);
            b.GetComponent<Rigidbody>().velocity = dir * 100;
            //aud.Play ();
            aud.PlayOneShot(fire_sound);
            Destroy(b, 3);

        }
        //print(this.transform.right);
    }


}
