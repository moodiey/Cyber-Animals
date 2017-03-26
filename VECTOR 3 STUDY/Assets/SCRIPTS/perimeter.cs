using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perimeter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision c)

    {
        GameObject x = c.gameObject;
        Destroy(x);

       /// print("GARBAGE CLEANUP");

    }
}
