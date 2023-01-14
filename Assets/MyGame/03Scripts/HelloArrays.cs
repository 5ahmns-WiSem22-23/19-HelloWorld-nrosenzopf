using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArrays : MonoBehaviour
{


    public static string[,] myArray = new string[3, 4]
  {
        {"A", "B", "C", "D" },
        {"E", "F", "G", "H" },
        {"I", "J", "K", "L" }
  };


    void Start()
    {
        int rowLength = myArray.GetLength(0);
        int colLength = myArray.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Debug.Log(myArray[i, j]);
            }
        }
    }
}
