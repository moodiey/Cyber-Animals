using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitty : MonoBehaviour {

    private Vector3 relativePos;

    private GameObject target;

    // Use this for initialization
    void Start () {

        target = GameObject.FindGameObjectWithTag("Player");

    }
	
	// Update is called once per frame
	void Update () {

        relativePos = target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;

    }
}
