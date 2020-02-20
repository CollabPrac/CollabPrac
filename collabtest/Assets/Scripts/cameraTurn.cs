using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTurn : MonoBehaviour
{
    public bool canTurnLeft;
    public bool canTurnRight;
    private float rotateWall = 0.2f;
    private float rotation;
    public Rigidbody camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Rigidbody>();
        canTurnLeft = true;
        canTurnRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotation = camera.transform.rotation.y;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //if (canTurnLeft == true)
            //{
            //    transform.Rotate(new Vector3(0, -1, 0) * 30f * Time.deltaTime);
            //    canTurnRight = true;
            //}
            TurnLeft();

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //if (canTurnRight == true)
            //{
            //    transform.Rotate(new Vector3(0, 1, 0) * 30f * Time.deltaTime);
            //    canTurnLeft = true;
            //}

            TurnRight();
        }

        if (rotation >= rotateWall)
        {
            canTurnRight = false;
        }

        if (rotation <= -rotateWall)
        {
            canTurnLeft = false;
        }
    }

    public void TurnLeft()
    {
        if (canTurnLeft == true)
        {
            transform.Rotate(new Vector3(0, -1, 0) * 30f * Time.deltaTime);
            canTurnRight = true;
        }
    }

    public void TurnRight()
    {
        if (canTurnRight == true)
        {
            transform.Rotate(new Vector3(0, 1, 0) * 30f * Time.deltaTime);
            canTurnLeft = true;
        }
    }
}
