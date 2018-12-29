using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFactoryScript : MonoBehaviour
{
    public GameObject car;

    private void Start()
    {
        InvokeRepeating("SpawnCar", 1.0f, 10.0f);
    }

    private void Update()
    {
        
    }

    private void SpawnCar()
    {
        Quaternion rotation = transform.rotation;
        Instantiate(car, new Vector3(-10.0f, 0.9f, -5.0f), rotation);
        Instantiate(car, new Vector3(0.9f, 10.0f, -5.0f), rotation);
        Instantiate(car, new Vector3(-0.9f, -10.0f, -5.0f), rotation);
        Instantiate(car, new Vector3(10.0f, -0.9f, -5.0f), rotation);
    }
}
