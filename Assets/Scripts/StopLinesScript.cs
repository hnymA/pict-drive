using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLinesScript : MonoBehaviour
{
    public Material stopLineMaterial;

    private void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        LineRenderer renderer = gameObject.GetComponent<LineRenderer>();
        renderer.material = stopLineMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(2);

        BoxCollider collider = gameObject.GetComponent<BoxCollider>();

        // TODO: adjust size according to screen resolution
        switch (this.name)
        {
            case "LeftTopStopLine":
                SetLeftTopPosition(renderer);
                SetLeftTopCollider(collider);
                break;
            case "LeftBottomStopLine":
                SetLeftBottomPosition(renderer);
                SetLeftBottomCollider(collider);
                break;
            case "RightTopStopLine":
                SetRightTopPosition(renderer);
                SetRightTopCollider(collider);
                break;
            case "RightBottomStopLine":
                SetRightBottomPosition(renderer);
                SetRightBottomCollider(collider);
                break;
        }

    }

    private void Update()
    {
        
    }

    private static void SetLeftTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-2.3f, 1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(-2.3f, 0.2f, -5.0f));
    }

    private static void SetLeftBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-1.5f, -2.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(-0.3f, -2.3f, -5.0f));
    }

    private static void SetRightTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(1.5f, 2.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(0.3f, 2.3f, -5.0f));
    }

    private static void SetRightBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(2.3f, -1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(2.3f, -0.2f, -5.0f));
    }

    private static void SetLeftTopCollider(BoxCollider collider)
    {
        collider.center = new Vector3(0.43f, 1.7f, -13.55f);
        collider.size = new Vector3(0.14f, 1.4f, 0.1f);
    }
    
    private static void SetLeftBottomCollider(BoxCollider collider)
    {
        collider.center = new Vector3(1.85f, -1.45f, -13.55f);
        collider.size = new Vector3(1.4f, 0.14f, 0.1f);   
    }
    
    private static void SetRightTopCollider(BoxCollider collider)
    {
        collider.center = new Vector3(3.6f, 3.13f, -13.55f);
        collider.size = new Vector3(1.4f, 0.14f, 0.1f);   
    }
    
    private static void SetRightBottomCollider(BoxCollider collider)
    {
        collider.center = new Vector3(5.03f, 0f, -13.55f);
        collider.size = new Vector3(0.14f, 1.4f, 0.1f);  
    }

}
