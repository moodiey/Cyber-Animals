using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour {

    private Image lifeCounter;

   // private GameObject gm;

    void Start()
    {

        lifeCounter = GetComponent<Image>();

       // gm = GameObject.FindGameObjectWithTag("gamemaster");

    }

    void FixedUpdate()
    {

        lifeCounter.fillAmount = cagescript.playerLife / 10000;

        // print(gm.GetComponent<gamemaster>().foodAmmo);

    }
}
