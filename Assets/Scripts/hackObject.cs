using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hackObject : MonoBehaviour
{
    [SerializeField]
    public Transform ActivePart;
    public Rigidbody Part0;
    public Rigidbody Part1;
    public Rigidbody Part2;
    public Rigidbody Part3;
    public Rigidbody Part4;
    public Rigidbody Part5;
    int place = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translation = new Vector3(0, 0, 0);
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            place = place + 1;
            translation += new Vector3(0, -2);
            ActivePart.transform.Translate(translation);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (place >= 1)
            {
                place = place - 1;
                translation += new Vector3(0, 2);
                ActivePart.transform.Translate(translation);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (place == 0)
            {
                Rigidbody part0_inst = Instantiate(Part0, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(4, 0);
                transform.Translate(translation);
            }

            if (place == 1)
            {
                Rigidbody part1_inst = Instantiate(Part1, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(4, 0);
                transform.Translate(translation);
            }

            if (place == 2)
            {
                Rigidbody part2_inst = Instantiate(Part2, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(0, 3);
                transform.Translate(translation);
            }

            if (place == 3)
            {
                Rigidbody part3_inst = Instantiate(Part3, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(0, -3);
                transform.Translate(translation);
            }

            if (place == 4)
            {
                Rigidbody part4_inst = Instantiate(Part4, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(4, 0);
                transform.Translate(translation);
            }

            if (place == 5)
            {
                Rigidbody part5_inst = Instantiate(Part5, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(0, 3);
                transform.Translate(translation);
            }
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag =="End")
        {
            Destroy(gameObject);
        }
    }
}
