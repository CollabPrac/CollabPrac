using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RememberingChoices : MonoBehaviour
{
    //Defining the variables needed for the system.
    string currentChoice;
    int turn = 0;
    int ALen = 0;
    int BLen = 0;
    int CLen = 0;

    bool OptionA = false;
    bool OptionB = false;
    bool OptionC = false;

    char[] ArrayA = new char[0];
    char[] ArrayB = new char[0];
    char[] ArrayC = new char[0];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OptionsChosen();

        EndingofGame();

    }

    void OptionsChosen()
    {
        if (currentChoice == "A")
        {
            OptionA = true;
            ArrayA[0] = ArrayA[+1];
            turn = turn + 1;
        }

        else if (currentChoice == "B")
        {
            OptionB = true;
            ArrayB[0] = ArrayB[+1];
            turn = turn + 1;
        }

        else if (currentChoice == "C")
        {
            OptionC = true;
            ArrayC[0] = ArrayC[+1];
            turn = turn + 1;
        }

    }

    void EndingofGame()
    {
        ALen = ArrayA.Length;
        Debug.Log(ALen);

        BLen = ArrayB.Length;
        Debug.Log(BLen);

        CLen = ArrayC.Length;
        Debug.Log(CLen);

        if(ALen > BLen)
        {
            if (ALen > CLen)
            {
                //This would have a link to the appropriate ending.
            }
        }

        else if (BLen > ALen)
        {
            if (BLen > CLen)
            {
                //This would have a link to the appropriate ending.
            }
        }

        else if (ALen > CLen)
        {
            if (CLen > BLen)
            {
                //This would have a link to the appropriate ending.
            }
        }


        else if (CLen > ALen)
        {
            if (CLen > BLen)
            {
                //This would have a link to the appropriate ending.
            }
        }
    }

   
}
