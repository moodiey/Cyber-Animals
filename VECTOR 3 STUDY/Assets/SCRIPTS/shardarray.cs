using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shardarray : MonoBehaviour
{

    public Transform animal;
    public Transform[] animalArray;
    public int animalArraySize;

    public float animalTimer;

    //  private Vector3 animalPosition;

    // Use this for initialization
    void Start()
    {

        animalArray = new Transform[animalArraySize * animalArraySize * animalArraySize];

       // animalTimer = 5;

        AnimalBoom();

        //  Debug.Log(animalArray.Length);
        //  Debug.Log(animalPosition);
    }

    public void AnimalBoom()
    {
        int x = 0;
        int y = 0;
        int z = 0;
        int i = 0;
        int count = 0;

        for (i = 0; i < 1; i++)
        {
            for (x = 0; x < animalArraySize; x++)
            {
                for (y = 0; y < animalArraySize; y++)
                {
                    for (z = 0; z < animalArraySize; z++)
                    {
                        animalArray[count] = Instantiate(animal, transform.position + new Vector3(x + Random.Range(-3.0f, 3.0f), y + Random.Range(-3.0f, 3.0f), z + Random.Range(-3.0f, 3.0f)), Quaternion.identity);
                        count += 1;
                        Debug.Log(count);
                    }
                }
            }
        }

    }

        /* INSTANTIATE THEM DIAGONALLY
        for (i = 0; i < shardArray.Length; i++)
        {
                    for (x = 0; x < shardArray.Length; x++)
                    {
                        shardArray[i] = Instantiate(shard, shardPosition + new Vector3(x, y, z), Quaternion.identity);
                        y += 1;
                        z += 1;
                    }
        }*/

    void Update()
    {
        animalTimer -= Time.deltaTime;

        if (animalTimer <= Time.deltaTime)
        {
             AnimalBoom();
             animalTimer = 9;
        }
    }
}