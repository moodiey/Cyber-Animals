using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comacat : MonoBehaviour {

    public float walkSpeed;

    public float walkSpeedOriginal;

    private GameObject target;

    private Vector3 relativePos;

    private Rigidbody rb;

    private Vector3 moveTowards;

    //public Vector3 vel;

   // private enum States { walking, beingfed };

   // private States thestate;

    // Use this for initialization
    void Start () {

        walkSpeedOriginal = walkSpeed;

        target = GameObject.FindGameObjectWithTag("Player");

      //  rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

           float step = walkSpeed * Time.deltaTime;
           transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);

    //  moveTowards = target.transform.position - transform.position;
    //  rb.AddForce(moveTowards * walkSpeed);

        relativePos = target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;

    //  vel = rb.velocity;

    }

    public static void ResetCat()

    {

    }


}
