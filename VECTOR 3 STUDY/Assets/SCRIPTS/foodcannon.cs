using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodcannon : MonoBehaviour {


  //  public Color c1 = Color.yellow;
   // public Color c2 = Color.red;
   // public int lengthOfLineRenderer = 20;

    public Transform aim;
    public Transform CannonAim;

    private LineRenderer lineRenderer;

 //   float alpha = 1.0f;

    private Camera cam;


    // Use this for initialization
    void Start () {

        cam = Camera.main;

      //  lineRenderer = gameObject.GetComponent<LineRenderer>();
      //  lineRenderer.numPositions = 2;

    }
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.LookRotation(cam.transform.forward);

        //  lineRenderer.SetPosition(0, transform.position);
        //  lineRenderer.SetPosition(1, aim.position);

    }
}
