using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_bank : MonoBehaviour {

    //////

    public static prefab_bank instance;

    public GameObject dogeBoom;
    public GameObject comacatBoom;

    public static GameObject aDogeBoom { get { return instance.dogeBoom; } }

    public static GameObject aComacatBoom { get { return instance.comacatBoom; } }

    //////


    void Awake()
    {
        instance = this;
    }
}
