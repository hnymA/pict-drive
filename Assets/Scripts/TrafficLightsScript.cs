using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrafficLightsScript : MonoBehaviour
{
    public Material frameMaterial;
    public Material greenSignalMaterial;
    public Material redSignalMaterial;

    private GameObject frameObject;
    private GameObject greenSignalObject;
    private GameObject redSignalObject;

    void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        this.frameObject = gameObject.transform.Find("Frame").gameObject;
        this.greenSignalObject = gameObject.transform.Find("GreenSignal").gameObject;
        this.redSignalObject = gameObject.transform.Find("RedSignal").gameObject;
        
        LineRenderer renderer = frameObject.GetComponent<LineRenderer>();
        renderer.material = frameMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(3);

        switch (this.name)
        {
            case "LeftTopTrafficSignal":
                SetLeftTopFramePosition(renderer);
                SetLeftTopSignalPosition(greenSignalObject, redSignalObject);
                break;
            case "LeftBottomTrafficSignal":
                SetLeftBottomFramePosition(renderer);
                SetLeftBottomSignalPosition(greenSignalObject, redSignalObject);
                break;
            case "RightTopTrafficSignal":
                SetRightTopFramePosition(renderer);
                SetRightTopSignalPosition(greenSignalObject, redSignalObject);
                break;
            case "RightBottomTrafficSignal":
                SetRightBottomFramePosition(renderer);
                SetRightBottomSignalPosition(greenSignalObject, redSignalObject);
                break;
        }
    }

    void Update()
    {
        // TODO: switch traffic light signal

        Image greenSignalImage = greenSignalObject.GetComponent<Image>();
        Image redSignalImage = redSignalObject.GetComponent<Image>();
        
        switch (this.name)
        {
            case "LeftTopTrafficSignal":
                redSignalImage.enabled = false;
                break;
            case "LeftBottomTrafficSignal":
                greenSignalImage.enabled = false;
                break;
            case "RightTopTrafficSignal":
                greenSignalImage.enabled = false;
                break;
            case "RightBottomTrafficSignal":
                redSignalImage.enabled = false;
                break;
        }
    }

    void SetLeftTopFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(-3f, 2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void SetLeftBottomFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(-3f, -2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void SetRightTopFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(3f, 2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void SetRightBottomFramePosition(LineRenderer renderer)
    {
        this.transform.position = new Vector3(3f, -2.5f, -5.0f);
        Vector3 parent = this.transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    void SetLeftTopSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        Vector3 parent = this.transform.position;
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        Image greenSignalImage = greenSignal.GetComponent<Image>();
        Image redSignalImage = redSignal.GetComponent<Image>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }

    void SetLeftBottomSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        Vector3 parent = this.transform.position;
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        Image greenSignalImage = greenSignal.GetComponent<Image>();
        Image redSignalImage = redSignal.GetComponent<Image>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }

    void SetRightTopSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        Vector3 parent = this.transform.position;
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        Image greenSignalImage = greenSignal.GetComponent<Image>();
        Image redSignalImage = redSignal.GetComponent<Image>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }

    void SetRightBottomSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        Vector3 parent = this.transform.position;
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        Image greenSignalImage = greenSignal.GetComponent<Image>();
        Image redSignalImage = redSignal.GetComponent<Image>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }
}
