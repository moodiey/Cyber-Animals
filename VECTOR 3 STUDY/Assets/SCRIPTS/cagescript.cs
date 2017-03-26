using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cagescript : MonoBehaviour
{

   // private enum collisionstate { nottouching, touching }
   // private collisionstate thecollisionstate;

    public static float playerLife;
    private bool playEffect;
    public Animator anim;
    public Transform player;

    public GameObject dieScene;


    // Use this for initialization
    void Start()
    {

        playerLife = 10000f;


      //  anim.SetBool("playEffect", false);

        //     playEffect = anim.GetBool(go);

    }

    /* void OnCollisionEnter(Collision c)

     {
         if (c.gameObject.tag == "comacat")
         {
             var Joint = gameObject.AddComponent<FixedJoint>();
             Joint.connectedBody = c.rigidbody;
         }
     }  */

    void Update()
    {
        transform.position = player.transform.position;

        if (playerLife <= 0f)
        {
            Time.timeScale = 0.0f;
            dieScene.SetActive(true);

        }
    }

    private void OnCollisionEnter(Collision c)
    {
       playerLife -= 100f;
    }

    private void OnCollisionStay(Collision collision)
    {
       // print("YEAH!!!!!");

     //   if (anim.GetBool("playEffect") == false)
      //  {
    //        anim.SetBool("playEffect", true); 
       // }s

        playerLife -= 1f;

    }


    private void OnCollisionExit(Collision collision)
    {
      //  anim.SetBool("playEffect", false);
    }
    
}