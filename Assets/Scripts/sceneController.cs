using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneController : MonoBehaviour
{
    public bool CanComputer;

    public Camera Main;
    public Camera Secondary;
    public Camera Computer;
    public Canvas MainCanvas;
    public Canvas SecondCanvas;
    public Canvas InventoryCanvas;
    public Canvas ComputerCanvas;
    public GameObject ItemImage;
    // Start is called before the first frame update
    void Start()
    {
        CanComputer = false;
        Main.gameObject.SetActive(true);
        Secondary.gameObject.SetActive(false);
        Computer.gameObject.SetActive(false);
        MainCanvas.gameObject.SetActive(true);
        SecondCanvas.gameObject.SetActive(false);
        InventoryCanvas.gameObject.SetActive(true);
        ComputerCanvas.gameObject.SetActive(false);
        ItemImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
