using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammo : MonoBehaviour {

    private Image ammoCounter;

    private GameObject gm;

	void Start () {

        ammoCounter = GetComponent<Image>();

        gm = GameObject.FindGameObjectWithTag("gamemaster");

    }
	
	void FixedUpdate () {

        ammoCounter.fillAmount = gm.GetComponent<gamemaster>().foodAmmo / 50;

       // print(gm.GetComponent<gamemaster>().foodAmmo);

    }
}
