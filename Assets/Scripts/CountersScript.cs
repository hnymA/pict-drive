using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountersScript : MonoBehaviour
{
    
    private GameObject _parent;
    private GameObject _leftTopCounter;
    private GameObject _leftBottomCounter;
    private GameObject _rightBottomCounter;
    private GameObject _rightTopCounter;

    private const float ChangeTime = 15.0f;
    private float _remainingTime = ChangeTime;
    
//    public delegate void CountHandler();
//    public static event CountHandler Count;
    
    private void Start()
    {
        FindGameObjects();
        Vector3 parentPosition = _parent.transform.position;
        float parentPositionX = parentPosition.x;
        float parentPositionY = parentPosition.y;
        
        SetCounterPosition(ref _leftTopCounter, parentPositionX - 350f, parentPositionY + 195f);
        SetCounterPosition(ref _leftBottomCounter, parentPositionX - 350f, parentPositionY - 195f);
        SetCounterPosition(ref _rightBottomCounter, parentPositionX + 350f, parentPositionY - 195f);
        SetCounterPosition(ref _rightTopCounter, parentPositionX + 350f, parentPositionY + 195f);
    }

    private void Update()
    {
        _remainingTime -= Time.deltaTime;
        SetCounterText(_leftTopCounter, _remainingTime);
        SetCounterText(_leftBottomCounter, _remainingTime);
        SetCounterText(_rightBottomCounter, _remainingTime);
        SetCounterText(_rightTopCounter, _remainingTime);
       
        if (_remainingTime < 0)
        {
            _remainingTime = ChangeTime;
//            Count();
        }
    }

    public float GetRemainingTime()
    {
        return _remainingTime;
    }
    
    private void FindGameObjects()
    {
        _parent = GameObject.Find("Counters");
        _leftTopCounter = GameObject.Find("LeftTopCounter");
        _leftBottomCounter = GameObject.Find("LeftBottomCounter");
        _rightBottomCounter = GameObject.Find("RightBottomCounter");
        _rightTopCounter = GameObject.Find("RightTopCounter");
    }
    
    private void SetCounterPosition(ref GameObject target, float x, float y)
    {
        Vector3 tmp = target.transform.position;
        tmp.x = x;
        tmp.y = y;
        target.transform.position = tmp;
    }

    private void SetCounterText(GameObject target, float time)
    {
        Text targetText = target.GetComponent<Text>();
        targetText.text = Math.Round(time, 2).ToString("F2");
    }
}
