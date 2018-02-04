using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour {
    private float offsetR = 0.5f; 
    private float offsetPhi = 5f; // degree
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
        //float up = (float)Convert.ToDouble(Input.GetKeyDown(KeyCode.W)) - (float)Convert.ToDouble(Input.GetKeyDown(KeyCode.S));
        //float right = (float)Convert.ToDouble(Input.GetKeyDown(KeyCode.D)) - (float)Convert.ToDouble(Input.GetKeyDown(KeyCode.A));
        float up = (float)Convert.ToDouble(Input.GetKey(KeyCode.W)) - (float)Convert.ToDouble(Input.GetKey(KeyCode.S));
        float right = (float)Convert.ToDouble(Input.GetKey(KeyCode.D)) - (float)Convert.ToDouble(Input.GetKey(KeyCode.A));
        float inside = Input.GetAxis("Mouse ScrollWheel");

        transform.RotateAround(Vector3.zero, transform.right, up * offsetPhi);
        transform.RotateAround(Vector3.zero, Vector3.up, right * offsetPhi);

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            transform.Translate(Vector3.forward * offsetR);
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
            transform.Translate(Vector3.forward * -offsetR);

    }
}
