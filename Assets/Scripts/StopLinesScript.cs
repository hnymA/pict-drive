using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLinesScript : MonoBehaviour
{
    public Material stopLineMaterial;

    void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        LineRenderer renderer = gameObject.GetComponent<LineRenderer>();
        renderer.material = stopLineMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(2);

        // TODO: adjust size according to screen resolution
        switch (this.name)
        {
            case "LeftTopStopLine":
                setLeftTopPosition(renderer);
                break;
            case "LeftBottomStopLine":
                setLeftBottomPosition(renderer);
                break;
            case "RightTopStopLine":
                setRightTopPosition(renderer);
                break;
            case "RightBottomStopLine":
                setRightBottomPosition(renderer);
                break;
        }

    }

    void Update()
    {
        
    }

    void setLeftTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-2.3f, 1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(-2.3f, 0.2f, -5.0f));
    }

    void setLeftBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-1.5f, -2.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(-0.3f, -2.3f, -5.0f));
    }

    void setRightTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(1.5f, 2.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(0.3f, 2.3f, -5.0f));
    }

    void setRightBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(2.3f, -1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(2.3f, -0.2f, -5.0f));
    }
}
