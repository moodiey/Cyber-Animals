using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counternew : MonoBehaviour {

    // public Transform target;

    public static TextMesh animalsfedcounter;
    public static int animalsfed;

    // Use this for initialization
    void Start()
    {

        animalsfedcounter = GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {

        animalsfedcounter.text = animalsfed.ToString();

    }
}
