using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightsScript : MonoBehaviour
{
    public Material frameMaterial;
    public Material greenSignalMaterial;
    public Material redSignalMaterial;

    void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        GameObject frameObject = gameObject.transform.Find("Frame").gameObject;
        GameObject greenSignalObject = gameObject.transform.Find("GreenSignal").gameObject;
        GameObject redSignalObject = gameObject.transform.Find("RedSignal").gameObject;

        LineRenderer renderer = frameObject.GetComponent<LineRenderer>();
        renderer.material = frameMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(3);

        switch (this.name)
        {
            case "LeftTopTrafficSignal":
                setLeftTopFramePosition(renderer);
                setLeftTopSignalPosition(greenSignalObject, redSignalObject);
                break;
            case "LeftBottomTrafficSignal":
                setLeftBottomFramePosition(renderer);
                setLeftBottomSignalPosition(greenSignalObject, redSignalObject);
                break;
            case "RightTopTrafficSignal":
                setRightTopFramePosition(renderer);
                setRightTopSignalPosition(greenSignalObject, redSignalObject);
                break;
            case "RightBottomTrafficSignal":
                setRightBottomFramePosition(renderer);
                setRightBottomSignalPosition(greenSignalObject, redSignalObject);
                break;
        }
    }

    void Update()
    {

    }

    void setLeftTopFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(-3f, 2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void setLeftBottomFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(-3f, -2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void setRightTopFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(3f, 2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void setRightBottomFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(3f, -2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void setLeftTopSignalPosition(GameObject greenSignal, GameObject redSignal)
    {

    }

    void setLeftBottomSignalPosition(GameObject greenSignal, GameObject redSignal)
    {

    }

    void setRightTopSignalPosition(GameObject greenSignal, GameObject redSignal)
    {

    }

    void setRightBottomSignalPosition(GameObject greenSignal, GameObject redSignal)
    {

    }
}
