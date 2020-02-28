using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourschanger : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    bool mouseOver = false;
    //Sets the camera and canvas object variables
    public Camera Main;
    public Camera Secondary;
    public Canvas MainCanvas;
    public Canvas SecondCanvas;

    private void Start()
    {
        Debug.Log("start");
        //Sets the main camera and canvas to active and the second camera and canvas to false
        Main.gameObject.SetActive(true);
        Secondary.gameObject.SetActive(false);
        MainCanvas.gameObject.SetActive(true);
        SecondCanvas.gameObject.SetActive(false);
    }

    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
        //If the left mouse button is clicked, Switches camera and canvas.
        if (Input.GetMouseButtonDown(0))
        {
            Main.gameObject.SetActive(false);
            Secondary.gameObject.SetActive(true);
            MainCanvas.gameObject.SetActive(false);
            SecondCanvas.gameObject.SetActive(true);
        }
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
    }
}
