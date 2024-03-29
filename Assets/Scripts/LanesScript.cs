﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanesScript : MonoBehaviour
{
    public Material courseMaterial;

    private void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        LineRenderer renderer = gameObject.GetComponent<LineRenderer>();
        renderer.material = courseMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(3);

        // TODO: adjust size according to screen resolution
        switch (name)
        {
            case "LeftTopLane":
                SetLeftTopPosition(renderer);
                break;
            case "LeftBottomLane":
                SetLeftBottomPosition(renderer);
                break;
            case "RightTopLane":
                SetRightTopPosition(renderer);
                break;
            case "RightBottomLane":
                SetRightBottomPosition(renderer);
                break;
        }
    }

    private void Update()
    {

    }

    private void SetLeftTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-8f, 1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(-1.5f, 1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(-1.5f, 5f, -5.0f));
    }

    private void SetLeftBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(-8f, -1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(-1.5f, -1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(-1.5f, -5f, -5.0f));
    }
    
    private void SetRightTopPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(8f, 1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(1.5f, 1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(1.5f, 5f, -5.0f));
    }
    
    private void SetRightBottomPosition(LineRenderer renderer)
    {
        renderer.SetPosition(0, new Vector3(8f, -1.5f, -5.0f));
        renderer.SetPosition(1, new Vector3(1.5f, -1.5f, -5.0f));
        renderer.SetPosition(2, new Vector3(1.5f, -5f, -5.0f));
    }
}