using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftButtonClick : MonoBehaviour
{
    //public Rigidbody camera;
    public GameObject camera;
    public cameraTurn turn;

    private void Start()
    {
        turn = camera.GetComponent<cameraTurn>();
    }

    public void ClickLeft()
    {
        turn.TurnLeft();
    }
}
