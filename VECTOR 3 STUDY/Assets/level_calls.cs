using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_calls : MonoBehaviour {

    private Animator camanim;

    public GameObject levelManager;



    // Use this for initialization
    void Start () {

        camanim = GetComponent<Animator>();

    }


    // Update is called once per frame
    void Update () {
		
	}

    public void PlayLevelOne ()
    {

        camanim.SetTrigger("up");

    }


    public void StartLevelOne()
    {

        for (int i = 0; i < levelManager.GetComponent<level_manager>().levelOneArray.Length; i++)
        {
            levelManager.GetComponent<level_manager>().levelOneArray[i].SetActive(true);
          //  print("ONE DOWN");
        
        }

        camanim.enabled = false;
        playermove.movestate = playermove.movementstate.moving;

    //    print("FUFUFUFUCKCKCKCKC");

    }

}
