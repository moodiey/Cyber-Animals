using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class UItext : MonoBehaviour {

    public static Text lifeCounter;
  //  public static int life;

    // Use this for initialization
    void Start () {

        //  life = cagescript.playerLife;
        lifeCounter = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        lifeCounter.text = "LIFE "+ cagescript.playerLife;

    }
}
