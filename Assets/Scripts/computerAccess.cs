using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerAccess : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    bool mouseOver = false;
    //Sets the camera and canvas object variables
    public sceneController sceneController;
    public Camera Main;
    public Camera Secondary;
    public Canvas MainCanvas;
    public Canvas SecondCanvas;

    private void Start()
    {
        Debug.Log("start");
        //Sets the main camera and canvas to active and the second camera and canvas to false
        sceneController = sceneController.GetComponent<sceneController>();
        Main.gameObject.SetActive(true);
        Secondary.gameObject.SetActive(false);
        MainCanvas.gameObject.SetActive(true);
        SecondCanvas.gameObject.SetActive(false);
    }

    void Update()
    {

        //If the left mouse button is clicked, Switches camera and canvas.
        if (mouseOver == true)
        {
            if (sceneController.CanComputer == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("test");
                    Main.gameObject.SetActive(false);
                    Secondary.gameObject.SetActive(true);
                    MainCanvas.gameObject.SetActive(false);
                    SecondCanvas.gameObject.SetActive(true);
                }
            }
        }
    }

    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
    }
}
