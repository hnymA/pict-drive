using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        // TODO: other directions
        Vector3 tmp = transform.position;
        tmp.x += 0.03f;
        transform.position = tmp;
    }
}
