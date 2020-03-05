using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

  private Inventory inventory;
  public GameObject itemButton;

    // Start is called before the first frame update
    private void Start()
    {
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter(Collider other) {
      if (other.CompareTag("Player")) {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
          if (inventory.isFull[i] == false) {
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
