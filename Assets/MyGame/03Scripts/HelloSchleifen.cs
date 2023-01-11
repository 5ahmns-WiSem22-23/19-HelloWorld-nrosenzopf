using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    public int[,] numbers = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


    // Start is called before the first frame update
    void Start()
    {
  
        for (int i = 0; i <=4; i++)
        {
            for (int j = 0; j <=2; j++)
            {
                Debug.Log(numbers[i, j] + " ");
            }
        }
    }



    // Update is called once per frame
  
}
