using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFactoryScript : MonoBehaviour
{
    public GameObject car;

    private void Start()
    {
        InvokeRepeating("WaitSpawnCar", 1.0f, 3.0f);
    }

    private void Update()
    {     

    }

    private void WaitSpawnCar()
    {
        float waitTime = Random.Range(1.0f, 3.0f);
        Invoke("SpawnCar", waitTime);
    }

    private void SpawnCar()
    {
        Quaternion rotation = transform.rotation;
        int spawnPlace = Random.Range(0, 4);

        switch (spawnPlace)
        {
            case 0:
                Instantiate(car, new Vector3(-10.0f, 0.9f, -5.0f), rotation);
                break;
            case 1:
                Instantiate(car, new Vector3(0.9f, 10.0f, -5.0f), rotation);
                break;
            case 2:
                Instantiate(car, new Vector3(-0.9f, -10.0f, -5.0f), rotation);
                break;
            case 3:
                Instantiate(car, new Vector3(10.0f, -0.9f, -5.0f), rotation);
                break;
        }
    }
    
    
}
