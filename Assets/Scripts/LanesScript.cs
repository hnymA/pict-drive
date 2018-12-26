using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanesScript : MonoBehaviour
{
    public Material courseMaterial;

    void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        LineRenderer renderer = gameObject.GetComponent<LineRenderer>();
        renderer.material = courseMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(3);

        // TODO: adjust size according to screen resolution
        switch (this.name)
        {
            case "LeftTopLane":
                setLeftTopPosition(renderer);
                break;
            case "LeftBottomLane":
                setLeftBottomPosition(renderer);
                break;
            case "RightTopLane":
                setRightTopPosition(renderer);
                break;
            case "RightBottomLane":
                setRightBottomPosition(renderer);
                break;
        }
    }

    void Update()
    {

    }

    void setLeftTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-8f, 1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(-1.5f, 1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(-1.5f, 5f, -5.0f));
    }

    void setLeftBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-8f, -1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(-1.5f, -1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(-1.5f, -5f, -5.0f));
    }
    
    void setRightTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(8f, 1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(1.5f, 1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(1.5f, 5f, -5.0f));
    }
    
    void setRightBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(8f, -1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(1.5f, -1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(1.5f, -5f, -5.0f));
    }
}