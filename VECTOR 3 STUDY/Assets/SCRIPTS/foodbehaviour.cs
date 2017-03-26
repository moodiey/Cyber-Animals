using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class foodbehaviour : MonoBehaviour {

    private Rigidbody c;
    private float foodTime;
    public int foodValue;

    private enum foodstates { readytoeat, beingeaten, eaten };

    private foodstates thefoodstate;

    private AudioSource squish;

    public Transform Player;

  //  public Transform dogeboom;

    private GameObject particles;


    // Use this for initialization
    void Start () {

        thefoodstate = foodstates.readytoeat;
        foodTime = 2.5f;
        squish = GetComponent<AudioSource>();

        // print(Joint.breakForce);

    }
	
	// Update is called once per frame
	void Update () {

        if (thefoodstate == foodstates.beingeaten)
        {
            foodBeingEaten();

        }
        if (thefoodstate == foodstates.eaten)
        {
            foodAte();
        }
    }

    void OnCollisionEnter(Collision c)

    {
        if (GetComponent<FixedJoint>() == null)
        {
            if (c.gameObject.tag == "terrain")
            {
                //Destroy(gameObject);
            }
            else if (c.gameObject.tag == "doge")
            {
                var Joint = gameObject.AddComponent<FixedJoint>();
                Joint.connectedBody = c.rigidbody;
                c.rigidbody.velocity = Vector3.zero;
                c.rigidbody.angularVelocity = Vector3.zero;
                Joint.enableCollision = true;
              //  print("JOINT ADDED");
                thefoodstate = foodstates.beingeaten;
                transform.SetParent(c.transform);
                squish.Play();
                particles = prefab_bank.aDogeBoom;

                c.transform.GetChild(1).localScale = new Vector3(150, 150, 150);
                c.transform.GetChild(2).localScale = new Vector3(150, 150, 150);
                c.transform.GetChild(3).localScale = new Vector3(120, 120, 120);
                c.transform.GetChild(4).localScale = new Vector3(120, 120, 120);
            }

            else if (c.gameObject.tag == "comacat")
            {
                var Joint = gameObject.AddComponent<FixedJoint>();
                Joint.connectedBody = c.rigidbody;
              //  c.rigidbody.velocity = Vector3.zero;
               // c.rigidbody.angularVelocity = Vector3.zero;
                Joint.enableCollision = true;
             //   print("JOINT ADDED");
                thefoodstate = foodstates.beingeaten;
                transform.SetParent(c.transform.parent);
                squish.Play();
                particles = prefab_bank.aComacatBoom;
                c.transform.parent.GetComponent<comacat>().walkSpeed = 0;
                c.transform.GetComponent<Animator>().enabled = false;

            }
        }
    }

    public void foodBeingEaten()

    {
       // print("EATING");

        foodTime -= Time.deltaTime;

      //   transform.parent.GetComponent<Rigidbody>().velocity = Vector3.zero;
      //  transform.parent.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
     //   transform.parent.GetComponent<Rigidbody>().isKinematic = true;

        if (foodTime <= Time.deltaTime)
        {
            thefoodstate = foodstates.eaten;
        }
    }

    public void foodAte()
    {
        GameObject attachedEnemy = transform.parent.gameObject;
        attachedEnemy.GetComponent<animal_life>().life -= foodValue;
     //   transform.parent.GetComponent<Rigidbody>().isKinematic = false;

        if (attachedEnemy.GetComponent<animal_life>().life <= 0)
        {
            Instantiate(particles, attachedEnemy.transform.position, attachedEnemy.transform.rotation);
            counternew.animalsfed += 1;
            Destroy(attachedEnemy);
        }
        else 
        {
            Destroy(gameObject);

            if (attachedEnemy.transform.GetChild(0).tag == "comacat")
            {

           //     print("FCUKCSKDCKSDKCSKD");
                attachedEnemy.GetComponent<comacat>().walkSpeed = attachedEnemy.GetComponent<comacat>().walkSpeedOriginal;
                attachedEnemy.transform.GetChild(0).GetComponent<Animator>().enabled = true;
            }

            // attachedEnemy.GetComponent<Rigidbody>().isKinematic = false;
        }

     //   print("ATE");

    }

}