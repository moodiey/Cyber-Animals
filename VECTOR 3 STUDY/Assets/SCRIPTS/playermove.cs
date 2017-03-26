using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

 //   public float PlayerSpeed;

    public enum movementstate { moving, notmoving };

    public static movementstate movestate;

    public float speed;

   // private Rigidbody rb;
 //   private Transform cam;

    public Transform target;

    // Use this for initialization
    void Start () {

   //     rb = GetComponent<Rigidbody>();

      //  cam = Camera.main.transform;

        movestate = movementstate.notmoving;

    }

    void Update()
    {
        if (movestate == movementstate.notmoving)
        {
            NotMoving();

        }
        if (movestate == movementstate.moving)
        {
            Moving();
        }
        //print(movestate);
    }

    // Update is called once per frame
    void Moving () {

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

  //      print("YAAAAAA");

        //  rb.AddForce(cam.forward * PlayerSpeed, ForceMode.Force);

    }

    void NotMoving()
    {

    }
}
