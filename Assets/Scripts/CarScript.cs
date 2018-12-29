using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class CarScript : MonoBehaviour
{
    private const byte LeftTop = 0;
    private const byte LeftBottom = 1;
    private const byte RightBottom = 2;
    private const byte RightTop = 3;
    
    private bool hasStopped;
    private byte bornPlace;
    
    private void Start()
    {
        Vector3 tmp = transform.position;
        if (tmp.x == -10.0f)
        {
            bornPlace = LeftTop;
        }

        if (tmp.x == -0.9f)
        {
            bornPlace = LeftBottom;
        }
        
        if (tmp.x == 10.0f)
        {
            bornPlace = RightBottom;
        }
        
        if (tmp.x == 0.9f)
        {
            bornPlace = RightTop;
        }        
    }

    private void Update()
    {
        float positionX = transform.position.x;
        float positionY = transform.position.y;
        
        if(!hasStopped) Move();
        
        if(positionX < -13.0f ||
           positionX > 13.0f ||
           positionY < -13.0f ||
           positionY > 13.0f) Destroy(gameObject);
    }

    private void Move()
    {
        Vector3 tmp = transform.position;
        const float speed = 0.03f;

        // TODO: other directions
        switch (bornPlace)
        {
            case LeftTop:
                tmp.x += speed;
                transform.position = tmp;
                break;
            case LeftBottom:
                tmp.y += speed;
                transform.position = tmp;
                break;
            case RightBottom:
                tmp.x -= speed;
                transform.position = tmp;
                break;
            case RightTop:
                tmp.y -= speed;
                transform.position = tmp;
                break;
        }

    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.name.Contains("StopLine"))
        {
            CheckTrafficMode(other);
        }
        else
        {
            hasStopped = true;            
        }
    }

    private void OnTriggerStay (Collider other)
    {
        if (other.name.Contains("StopLine"))
        {
            CheckTrafficMode(other);
        }
        else
        {
            hasStopped = true;            
        }
    }

    private void CheckTrafficMode(Collider other)
    {
        switch (TrafficSignsScript.GetCenterSignMode())
        {
            case "GoAll":
                hasStopped = false;
                break;
                    
            case "StopAll":
                hasStopped = true;
                break;
                    
            case "StopGreen":
                hasStopped = IsGreenSignal(other);
                break;
                
            case "StopRed":
                hasStopped = !IsGreenSignal(other);
                break;
        }
    }

    private bool IsGreenSignal(Collider other)
    {
        return TrafficSignalsScript.IsGreen(other.name.Replace("StopLine", "TrafficSignal"));  
    }
}
