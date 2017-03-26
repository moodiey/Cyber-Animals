using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetrotation : MonoBehaviour {

    private Transform cam;
   // private float yrot;

    public Transform player;

	// Use this for initialization
	void Start () {

        cam = Camera.main.transform;

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 eulerAngles = cam.rotation.eulerAngles;

        eulerAngles = new Vector3(0, eulerAngles.y, 0);

        transform.rotation = Quaternion.Euler(eulerAngles);


     //   yrot = cam.eulerAngles.y;

    //    transform.rotation = cam.rotation;
        transform.position = player.position;
		
	}
}
