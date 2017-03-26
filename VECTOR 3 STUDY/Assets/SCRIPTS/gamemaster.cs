using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
//using CnControls;

public class gamemaster : MonoBehaviour {

    public GameObject Player;
    public Transform RocketedAnimal;
    public Transform Cannon;
    public Transform CannonAim;

    [Space(30)]

    // FOOD FIRE MACHINE
    public Transform FoodCannon;
    public Transform FoodCannonAim;
    public Transform food;
    private Rigidbody foodrb;
    private Vector3 foodTowards;
    public float FoodSpeed;

 
    private Time time;
    public float joystickspeed;
    private Vector3 moveTowards;
  //  private Vector3 rocketTowards;
    private Vector3 foodAim;

    public float thrust;
    public float foodThrust;
    public float rocketTimer;

    public static int animalsfed;


 //   bool moving = false;
    GameObject go;

    public float fireDelay = 1f;
    public float timePassed = 0f;

    public float foodAmmo;
    public float life;

    public GameObject LineZoom;



    // Use this for initialization
    void Start () {

     //   rb = RocketedAnimal.GetComponent<Rigidbody>();

    //    rocketTowards = CannonAim.position - Cannon.position;

        

    }
	
	// Update is called once per frame
	void Update () {

        Debug.DrawLine(Cannon.position, CannonAim.position, Color.yellow);
        Debug.DrawLine(Player.transform.position, RocketedAnimal.position, Color.green);
        Debug.DrawLine(FoodCannon.position, FoodCannonAim.position, Color.blue);

        Debug.DrawLine(Player.transform.position, transform.position, Color.blue);

        /*     float clampedX = Mathf.Clamp(FoodCannonAim.position.x, -6000, 9000);
             float clampedY = Mathf.Clamp(FoodCannonAim.position.y, -300, 5800);

             foodAim.Set(clampedX + (CnInputManager.GetAxis("Horizontal") * joystickspeed) ,
                         clampedY + (CnInputManager.GetAxis("Vertical") * joystickspeed), 
                         FoodCannonAim.position.z );

             FoodCannonAim.position = foodAim;
             foodTowards = FoodCannonAim.position - FoodCannon.position;   */

        timePassed += Time.deltaTime;    

        if (Input.GetButton("Jump") && timePassed >= fireDelay && foodAmmo >= 5)
        {
            FireFood();
            timePassed = 0f;

        }

        /// <summary>
        /// SCREEN INPUT
        /// </summary>
        /// 

        if (Input.GetMouseButton(0) && timePassed >= fireDelay && foodAmmo >= 5)
        {
            FireFood();
        }

        rocketTimer -= Time.deltaTime;

        if (rocketTimer <= Time.deltaTime)
        {
            StartCoroutine(RocketAnimal());
            rocketTimer = 10;
        }

        if (foodAmmo < 50)
        {
            foodAmmo += .15f;

        }


        /*   if (Input.touchCount == 1)
            {    
                // touch on screen
                if(Input.GetTouch(0).phase == TouchPhase.Stationary && moving && timePassed >= fireDelay && foodAmmo >= 0)
                {
                        FireFood();
                        timePassed = 0f;
                         Debug.Log("TOUCHED");
                   }

                }
                */


    }

    IEnumerator RocketAnimal()
    {
   //     print("BOOOM");

        GameObject linezoomclone = Instantiate(LineZoom, Cannon.transform.position, Cannon.transform.rotation);

        yield return new WaitForSeconds(2.30f);

        Transform RocketedAnimalclone = Instantiate(RocketedAnimal, Cannon.transform.position, Quaternion.FromToRotation(-RocketedAnimal.forward, (Player.transform.position - Cannon.transform.position)));

        Destroy(linezoomclone);
        
    }

    public void FireFood()
    {

        Transform foodclone = Instantiate(food, FoodCannon.position, Quaternion.identity);
    //    foodclone.GetComponent<Rigidbody>().AddForce(foodTowards * thrust);

        foodclone.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * foodThrust, ForceMode.Force);

      //  print("FOOD FIRED");
        foodAmmo -= 3;
        

    }

}