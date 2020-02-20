using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightButtonClick : MonoBehaviour
{
    public GameObject camera;
    public cameraTurn turn;

    private void Start()
    {
        turn = camera.GetComponent<cameraTurn>();
    }

    public void ClickRight()
    {
        turn.TurnRight();
    }
}
