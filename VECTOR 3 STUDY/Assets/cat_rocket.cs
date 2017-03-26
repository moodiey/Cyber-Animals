using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_rocket : MonoBehaviour
{

    public float timer;

    public GameObject animal;

    public Transform target;

    public Vector3[] positionarray;

 /* public Vector3 position1;
    public Vector3 position2;
    public Vector3 position3;
    public Vector3 position4;

    [Space(30)]

    public Quaternion rotation1;
    public Quaternion rotation2;
    public Quaternion rotation3;
    public Quaternion rotation4; */

    private int i;

  //  private string position;

    // Use this for initialization
    void Start()
    {

     //   positionarray = new Vector3[4];
     //   rotationarray = new Quaternion[4];

        i = 0;

        print(positionarray[i]);

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= Time.deltaTime)
        {
            CreateAnimal();
            timer = 5;
        }

        Debug.DrawLine(target.position, transform.position, Color.red);
    }

    public void CreateAnimal()
    {
       // string currentposition = position[i];

        GameObject animalclone = Instantiate(animal, positionarray[i], Quaternion.identity);

        if (i <= 2)
        {
            i += 1;
        }
        else
        {
            i = 0;
        }
        


       // var anim = animalclone.GetComponent<Animator>();
       // anim.enabled = true;

        //   animalclone.transform.rotation = Quaternion.FromToRotation(-animalclone.transform.up, (target.position - transform.position));
     //   animalclone.transform.rotation.Set(-94, 190, -122, 0);


        //  animalclone.transform.rotation.SetLookRotation((target.position - transform.position), Vector3.up);

    }
}