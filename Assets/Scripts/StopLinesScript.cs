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
                SetLeftTopPosition(renderer);
                break;
            case "LeftBottomStopLine":
                SetLeftBottomPosition(renderer);
                break;
            case "RightTopStopLine":
                SetRightTopPosition(renderer);
                break;
            case "RightBottomStopLine":
                SetRightBottomPosition(renderer);
                break;
        }

    }

    void Update()
    {
        
    }

    void SetLeftTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-2.3f, 1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(-2.3f, 0.2f, -5.0f));
    }

    void SetLeftBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-1.5f, -2.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(-0.3f, -2.3f, -5.0f));
    }

    void SetRightTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(1.5f, 2.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(0.3f, 2.3f, -5.0f));
    }

    void SetRightBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(2.3f, -1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(2.3f, -0.2f, -5.0f));
    }
}
