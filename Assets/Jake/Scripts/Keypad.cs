using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

//Code Written By Jake Harris - S18127371
public class Keypad : MonoBehaviour
{
    [SerializeField]
    private GameObject keypadCanvas;
    public bool keypadActive = false;
    [SerializeField]
    private Text keypadText;

    private String code = "23456";
    private int maxCodeLength = 5;

    void Update()
    {
        if (keypadActive && Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleKeypad();
        }
    }

    void ToggleKeypad()
    {
        keypadActive = !keypadActive;
        keypadCanvas.SetActive(keypadActive);
    }

    public void InputNumber(int number)
    {
        Debug.Log("test");
        if (keypadText.text == "X")
        {
            ClearDisplay();
        }
        if (keypadText.text.Length < maxCodeLength)
        {
            keypadText.text += number.ToString();
        }
    }

    public void ClearDisplay()
    {
        keypadText.text = "";
    }

    public void CheckCode()
    {
        if (keypadText.text == code)
        {
            //set boolean to true to allow access to computer
            ToggleKeypad();
        }
        else
        {
            keypadText.text = "X";
        }
    }
}
