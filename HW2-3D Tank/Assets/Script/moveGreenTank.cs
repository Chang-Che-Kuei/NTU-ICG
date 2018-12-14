using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGreenTank : MonoBehaviour {

	static public float speed = 30.0f;

	public GameObject bulletObj;
	public GameObject fireObj;
	public AudioClip fire_sound;
	private AudioSource aud;
    private GameObject player;
	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource> ();
        player = GameObject.Find("Tank_pref");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 dis = player.transform.position - this.transform.position;
        if (dis.magnitude > 20)
        {
            float step = 10.0f * Time.deltaTime;
            // Move our position a step closer to the target.
            transform.position = 
                Vector3.MoveTowards(transform.position, player.transform.position, step);
        }

        Vector3 faceDir = this.transform.right;
        float theta = Vector3.Angle(faceDir, dis);
        print(theta);
        if (theta > 5)
            this.transform.Rotate(0, Time.deltaTime * 60, 0);

        if (dis.magnitude <= 50 && Random.Range(1.0f,50.0f)<2)//0.02 probability to shoot
        {
            GameObject b = Instantiate(bulletObj, fireObj.transform.position, fireObj.transform.rotation) as GameObject;
            Vector3 dir = transform.TransformDirection(Vector3.right);
            b.GetComponent<Rigidbody>().velocity = dir * 100;
            aud.PlayOneShot(fire_sound);
            Destroy(b, 3);
        }

        /*
        if (Input.GetKey (KeyCode.UpArrow))
			this.transform.Translate (speed * Time.deltaTime, 0, 0);
		if (Input.GetKey (KeyCode.DownArrow))
			this.transform.Translate (-speed * Time.deltaTime, 0, 0);
		if (Input.GetKey (KeyCode.LeftArrow))
			this.transform.Rotate (0, -90* Time.deltaTime, 0);
		if(Input.GetKey (KeyCode.RightArrow))
			this.transform.Rotate (0, 90* Time.deltaTime, 0);

		if (Input.GetKeyDown (KeyCode.Return)) {
			GameObject b = Instantiate (bulletObj, fireObj.transform.position, fireObj.transform.rotation) as GameObject;
			Vector3 dir = transform.TransformDirection(Vector3.right);
			b.GetComponent<Rigidbody> ().velocity = dir *100;
			aud.PlayOneShot (fire_sound);
			Destroy (b, 3);
		}
        */
    }
}
