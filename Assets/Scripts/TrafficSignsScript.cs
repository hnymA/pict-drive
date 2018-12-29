using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSignsScript : MonoBehaviour
{
    private static Dictionary<GameObject, bool> _isCenterDictionary = new Dictionary<GameObject, bool>();

    private GameObject _parent;
    private GameObject _defaultButton;
    private GameObject _diagonalUpButton;
    private GameObject _roundButton;
    private GameObject _exclamationButton;
    private GameObject _questionButton;

    private void Start()
    {
        FindGameObjects();

        if (this.name != "Default")
        {
            gameObject.SetActive(false);
            _isCenterDictionary.Add(gameObject, false);
        }
        else
        {
            _isCenterDictionary.Add(gameObject, true);
        }
    }

    private void Update()
    {
    }

    private void FindGameObjects()
    {
        _parent = GameObject.Find("TrafficSigns");
        _defaultButton = _parent.transform.Find("Default").gameObject;
        _diagonalUpButton = _parent.transform.Find("Diagonal Up").gameObject;
        _roundButton = _parent.transform.Find("Round").gameObject;
        _exclamationButton = _parent.transform.Find("Exclamation").gameObject;
        _questionButton = _parent.transform.Find("Question").gameObject;
    }

    public void OnClick()
    {
        GameObject target = gameObject;

        if (_isCenterDictionary[target])
        {
            _defaultButton.SetActive(false);
            _diagonalUpButton.SetActive(true);
            _roundButton.SetActive(true);
            _exclamationButton.SetActive(true);
            _questionButton.SetActive(true);

            ShiftButtonPosition(ref _diagonalUpButton, -120f, -120f);
            ShiftButtonPosition(ref _roundButton, -120f, 120f);
            ShiftButtonPosition(ref _exclamationButton, 120f, 120f);
            ShiftButtonPosition(ref _questionButton, 120f, -120f);

            _isCenterDictionary[target] = false;
        }
        else
        {
            _isCenterDictionary[target] = true;

            foreach (KeyValuePair<GameObject, bool> pair in _isCenterDictionary)
            {
                if (pair.Value == false)
                {
                    pair.Key.SetActive(false);
                }
                else
                {
                    pair.Key.SetActive(true);
                }
            }

            Vector3 parentPosition = _parent.transform.position;
            float parentPositionX = parentPosition.x;
            float parentPositionY = parentPosition.y;

            SetButtonPosition(ref _diagonalUpButton, parentPositionX, parentPositionY);
            SetButtonPosition(ref _roundButton, parentPositionX, parentPositionY);
            SetButtonPosition(ref _exclamationButton, parentPositionX, parentPositionY);
            SetButtonPosition(ref _questionButton, parentPositionX, parentPositionY);
        }
    }

    private void ShiftButtonPosition(ref GameObject target, float x, float y)
    {
        Vector3 tmp = target.transform.position;
        tmp.x += x;
        tmp.y += y;
        target.transform.position = tmp;
    }

    private void SetButtonPosition(ref GameObject target, float x, float y)
    {
        Vector3 tmp = target.transform.position;
        tmp.x = x;
        tmp.y = y;
        target.transform.position = tmp;
    }
}