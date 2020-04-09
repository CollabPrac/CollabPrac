using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showItem : MonoBehaviour
{
    public GameObject itemImage;
    bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClick()
    {
        if(active == true)
        {
            itemImage.gameObject.SetActive(false);
            active = false;
        }

        else if (active == false)
        {
            itemImage.gameObject.SetActive(true);
            active = true;
        }
    }
}
