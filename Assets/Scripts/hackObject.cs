using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Transform End;
    float endPoint;
    int place = 0;
    int LastObject = 0;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float lastPositionX;
    public float lastPositionY;
    public int moveUp;
    public int moveDown;
    // Start is called before the first frame update
    void Start()
    {
        endPoint = End.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translation = new Vector3(0, 0, 0);
        if (transform.position.x >= maxX || transform.position.x <= minX || transform.position.y >= maxY || transform.position.y <= minY)
        {
            translation = new Vector3(lastPositionX, lastPositionY);
        }

        if(transform.position.x >= endPoint)
        {
            SceneManager.LoadScene(1);
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (place < 5)
            {
                place = place + 1;
                translation += new Vector3(0, -2);
                ActivePart.transform.Translate(translation);
            }
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
            lastPositionX = transform.position.x;
            lastPositionY = transform.position.y;
            if (place == 0)
            {
                if (LastObject != 5)
                {
                    Rigidbody part0_inst = Instantiate(Part0, transform.position, Quaternion.identity) as Rigidbody;
                    translation += new Vector3(3, 0);
                    transform.Translate(translation);
                    LastObject = 0;
                }
            }

            if (place == 1)
            {
                Rigidbody part1_inst = Instantiate(Part1, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(4, 0);
                transform.Translate(translation);
                LastObject = 1;
            }

            if (place == 2)
            {
                Rigidbody part2_inst = Instantiate(Part2, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(0, 2);
                transform.Translate(translation);
                LastObject = 2;
            }

            if (place == 3)
            {
                Rigidbody part3_inst = Instantiate(Part3, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(0, -2);
                transform.Translate(translation);
                LastObject = 3;
            }

            if (place == 4)
            {
                Rigidbody part4_inst = Instantiate(Part4, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(4, 0);
                transform.Translate(translation);
                LastObject = 4;
            }

            if (place == 5)
            {
                Rigidbody part5_inst = Instantiate(Part5, transform.position, Quaternion.identity) as Rigidbody;
                translation += new Vector3(0, 2);
                transform.Translate(translation);
                LastObject = 5;
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
