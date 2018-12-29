using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrafficSignalsScript : MonoBehaviour
{
    public Material frameMaterial;

    private GameObject _frameObject;
    private GameObject _greenSignalObject;
    private GameObject _redSignalObject;
    private GameObject _counterObject;
    
    private static readonly Dictionary<string, bool> _isGreenDictionary = new Dictionary<string, bool>();

    private void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        FindGameObjects();
        
        LineRenderer renderer = _frameObject.GetComponent<LineRenderer>();
        Image greenSignalImage = _greenSignalObject.GetComponent<Image>();
        Image redSignalImage = _redSignalObject.GetComponent<Image>();
        
        renderer.material = frameMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(3);

        InitializeTrafficSignals(renderer);
        InitializeSignalImages(greenSignalImage, redSignalImage);
        InitializeCounters();
    }

    private void Update()
    {
        // TODO: switch traffic signal
        
        
    }
    
    private void FindGameObjects()
    {
        _frameObject = gameObject.transform.Find("Frame").gameObject;
        _greenSignalObject = gameObject.transform.Find("GreenSignal").gameObject;
        _redSignalObject = gameObject.transform.Find("RedSignal").gameObject;
        _counterObject = gameObject.transform.Find("Counter").gameObject;
    }

    private void InitializeTrafficSignals(LineRenderer renderer)
    {
        switch (name)
        {
            case "LeftTopTrafficSignal":
                SetLeftTopFramePosition(renderer);
                SetLeftTopSignalPosition(_greenSignalObject, _redSignalObject);
                SetLeftTopCounterPosition(_counterObject);
                break;
            case "LeftBottomTrafficSignal":
                SetLeftBottomFramePosition(renderer);
                SetLeftBottomSignalPosition(_greenSignalObject, _redSignalObject);
                SetLeftBottomCounterPosition(_counterObject);
                break;
            case "RightTopTrafficSignal":
                SetRightTopFramePosition(renderer);
                SetRightTopSignalPosition(_greenSignalObject, _redSignalObject);
                SetRightTopCounterPosition(_counterObject);
                break;
            case "RightBottomTrafficSignal":
                SetRightBottomFramePosition(renderer);
                SetRightBottomSignalPosition(_greenSignalObject, _redSignalObject);
                SetRightBottomCounterPosition(_counterObject);
                break;
        }   
    }

    private void InitializeSignalImages(Image greenSignalImage, Image redSignalImage)
    {
        switch (name)
        {
            case "LeftTopTrafficSignal":
                redSignalImage.enabled = false;
                _isGreenDictionary.Add(name, true);
                break;
            case "LeftBottomTrafficSignal":
                greenSignalImage.enabled = false;
                _isGreenDictionary.Add(name, false);
                break;
            case "RightTopTrafficSignal":
                greenSignalImage.enabled = false;
                _isGreenDictionary.Add(name, false);
                break;
            case "RightBottomTrafficSignal":
                redSignalImage.enabled = false;
                _isGreenDictionary.Add(name, true);
                break;
        }
    }
    
    public static bool IsGreen(string target)
    {
        return _isGreenDictionary[target];
    }
    
    /////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////

    private void SetLeftTopFramePosition(LineRenderer renderer)
    {
        transform.position = new Vector3(-3f, 2.5f, -5.0f);
        Vector3 parent = transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    private void SetLeftBottomFramePosition(LineRenderer renderer)
    {
        transform.position = new Vector3(-3f, -2.5f, -5.0f);
        Vector3 parent = transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    private void SetRightTopFramePosition(LineRenderer renderer)
    {
        transform.position = new Vector3(3f, 2.5f, -5.0f);
        Vector3 parent = transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }

    private void SetRightBottomFramePosition(LineRenderer renderer)
    {
        transform.position = new Vector3(3f, -2.5f, -5.0f);
        Vector3 parent = transform.position;

        renderer.SetPosition(0, new Vector3(parent.x - 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(1, new Vector3(parent.x + 0.5f, parent.y + 0.3f, -5.0f));
        renderer.SetPosition(2, new Vector3(parent.x + 0.5f, parent.y - 0.3f, -5.0f));
    }
    
    /////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////

    private void SetLeftTopSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }

    private void SetLeftBottomSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }

    private void SetRightTopSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }

    private void SetRightBottomSignalPosition(GameObject greenSignal, GameObject redSignal)
    {
        RectTransform greenSignalRectTransform = greenSignal.GetComponent<RectTransform>();
        RectTransform redSignalRectTransform = redSignal.GetComponent<RectTransform>();
        
        greenSignalRectTransform.localPosition = new Vector3(-0.25f, 0f, 0f);
        greenSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
        redSignalRectTransform.localPosition = new Vector3(0.25f, 0f, 0f);
        redSignalRectTransform.sizeDelta = new Vector2(0.4f, 0.4f);
    }
    
    /////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////
    
    private void SetLeftTopCounterPosition(GameObject counterObject)
    {
        throw new System.NotImplementedException();
    }

    private void SetLeftBottomCounterPosition(GameObject counterObject)
    {
        throw new System.NotImplementedException();
    }

    private void SetRightTopCounterPosition(GameObject counterObject)
    {
        throw new System.NotImplementedException();
    }

    private void SetRightBottomCounterPosition(GameObject counterObject)
    {
        throw new System.NotImplementedException();
    }

}
