using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspec : MonoBehaviour {
    public GameObject FirstPerson, Top; //two camera
    void Awake()
    {
        //open FP camera
        FirstPerson.SetActive(true);
        Top.SetActive(false);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("z") == true)
        {
            //FP camera
            FirstPerson.SetActive(true);
            Top.SetActive(false);
        }
        else if (Input.GetKey("x") == true)
        {
            //Top
            FirstPerson.SetActive(false);
            Top.SetActive(true);
        }
    }
}