using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalbehaviour : MonoBehaviour {

    private GameObject Player;
    private Rigidbody rb;
    private Vector3 moveTowards;

    public float thrust;
   // public int life;

  //  private enum states { notcollided, collided };

  //  private states thestate;


    // Use this for initialization
    void Start () {

       Player = GameObject.FindWithTag("Player");

        rb = GetComponent<Rigidbody>();

   //     thestate = states.notcollided;

    }
	

    /*
    private void OnCollisionStay(Collision collision)
    {
        thestate = states.collided;
        
    }

    private void OnCollisionExit(Collision collision)
    {
        thestate = states.notcollided;
    }

    public void collided()
    {
        print("COLLIDED");
    }

    public void notcollided()
    {
        print("NOOOOO TTTCOLLIDED");

    }
    */

    void FixedUpdate()
    {

      //  transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, thrust);

          moveTowards = Player.transform.position - transform.position;
          rb.AddForce(moveTowards * thrust);

          Debug.DrawLine(Player.transform.position, transform.position, Color.cyan);

    }
}
