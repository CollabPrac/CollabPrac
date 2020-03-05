using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    bool mouseOver = false;
    private Inventory inventory;
    public GameObject itemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("InventoryObject").GetComponent<Inventory>();
    }

    void Update()
    {
        //If the left mouse button is clicked, Switches camera and canvas.
        if (mouseOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Down");
                
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    Debug.Log("inv 1");
                    if (inventory.isFull[i] == false)
                    {
                        Debug.Log("inv2");
                        //item can be added hopefully
                        inventory.isFull[i] = true;
                        Instantiate(itemButton, inventory.slots[i].transform, false);
                        Destroy(gameObject);
                        break;
                    }
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
