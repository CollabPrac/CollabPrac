using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypadAccess : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    bool mouseOver = false;

    public sceneController sceneController;
    public Canvas MainCanvas;
    public Canvas SecondCanvas;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        sceneController = sceneController.GetComponent<sceneController>();
        MainCanvas.gameObject.SetActive(true);
        SecondCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                MainCanvas.gameObject.SetActive(false);
                SecondCanvas.gameObject.SetActive(true);
                wall.gameObject.SetActive(false);
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
