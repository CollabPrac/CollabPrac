//using System.Collections;
//using System.Collections.Generic;
//using System;
//using System.IO;
//using UnityEngine;

//public class Decisions : MonoBehaviour
//{
//    bool newGame = false;

//    // Start is called before the first frame update
//    void Start()
//    {
//        listCheck();
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    void listCheck()
//    {
//        if (newGame == true)
//        {

//            //This is using the StreamReader to allow the contents of a file to be read.
//            //The 'Using' statement also closes the StreamReader.
//            using (StreamReader sr = new StreamReader("d:/BCU/Second Year/Semester 2/Collaborative Practice/Collaborative Practice Project/Decisions.txt"))
//            {
//                string line;

//                //This reads the displayed lines until the end of the file is reached.
//                while ((line = sr.ReadLine()) != null) {
//                    Console.WriteLine(line);
//                }
//            }
//        }
//        else
//        {

//        }
//    }
//}

//Code sourced from: https://support.unity3d.com/hc/en-us/articles/115000341143-How-do-I-read-and-write-data-from-a-text-file-

using UnityEngine;
using UnityEditor;
using System.IO;

public class HandlingTheTextFile
{
    [MenuItem("Tools/Write file")]
    static void WriteString()
    {
        string path = "Assets/Resources/Decisions.txt";

        //Write some text to the Decisions.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Test");
        writer.Close();

        //Re-importing the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = Resources.Load("Decisions");

        //Print the text from the file
        Debug.Log(asset.text);
    }

    [MenuItem("Tools/Read file")]
    static void ReadString()
    {
        string path = "Assets/Resources/Decisions.txt";
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}