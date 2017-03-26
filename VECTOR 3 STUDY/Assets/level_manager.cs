using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class level_manager : MonoBehaviour {


    private enum levelstates { intro, level1, level2 }


    public GameObject[] levelOneArray;
  //  public static GameObject[] thelevelonearray;

    levelstates level;


    /*

    public static level_manager instance;

    public GameObject dogeBoom;
    public GameObject comacatBoom;

    public static GameObject aDogeBoom { get { return instance.dogeBoom; } }

    public static GameObject aComacatBoom { get { return instance.comacatBoom; } }


    */



    // Use this for initialization
    void Awake () {

        StartCoroutine(AddBloom());

        level = levelstates.intro;

      //  instance = this;



    }
	
	// Update is called once per frame
	void Update () {

        if (level == levelstates.level1)
        {
            level1();

        }
        if (level == levelstates.level2)
        {
            level2();
        }

    }

    IEnumerator AddBloom()

    {
        yield return new WaitForSeconds(.2f);

        GameObject postrender = GameObject.Find("PostRender");
        GameObject camleft = GameObject.Find("Main Camera Left");
        GameObject camright = GameObject.Find("Main Camera Right");
        postrender.AddComponent<BloomOptimized>();
        camleft.AddComponent<FlareLayer>();
        camright.AddComponent<FlareLayer>();

    }
    
    public void level1 ()
    {

    }

    public void level2()
    {

    }


}
