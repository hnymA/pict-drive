using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    private Boolean hasStopped = false;
    private void Start()
    {
        
    }

    private void Update()
    {
        if(!hasStopped) Move();   
    }

    private void Move()
    {
        // TODO: other directions
        Vector3 tmp = transform.position;
        tmp.x += 0.03f;
        transform.position = tmp;
    }

    private void OnTriggerEnter (Collider other)
    {
        hasStopped = true;
    }
    
}
