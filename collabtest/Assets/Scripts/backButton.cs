using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButton : MonoBehaviour
{
    public Camera Main;
    public Camera Secondary;
    public Canvas MainCanvas;
    public Canvas SecondCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Main.gameObject.SetActive(false);
        Secondary.gameObject.SetActive(true);
        MainCanvas.gameObject.SetActive(false);
        SecondCanvas.gameObject.SetActive(true);
    }

    public void ClickBack()
    {
        Main.gameObject.SetActive(true);
        Secondary.gameObject.SetActive(false);
        MainCanvas.gameObject.SetActive(true);
        SecondCanvas.gameObject.SetActive(false);
    }
}
