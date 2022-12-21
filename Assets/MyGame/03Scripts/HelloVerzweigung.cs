using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    public int a = 4;
    public string b = "female";
   public void cases()
    {
        int input = 2;
        switch (input)
        {
            case 1:
               Debug.Log("Input is 1");
                break;
            case 2:
              Debug.Log("Input is 2");
                break;
            case 3:
           Debug.Log("Input is 3");
                break;
            default:
            Debug.Log("Input is not 1, 2, or 3");
                break;
        }

        if (a > 18)
        {
            if ( b== "male")
            {
                Debug.Log("Du bist ein Mann.");
            }
            else if (b == "female")
            {
                Debug.Log("Du bist eine Frau");
            }
            else
            {
                Debug.Log("Ka was du bist");
            }
        }

        // Nested

        if (a < 8)
        {
            if (b == "female")
            {
                if (a < 5)
                {

                }
            }
        }


    }

    public int returndings(int a)
    {
        if (a < 0)
        {
            return 0;
        }
        return a * 2;
    }


    public void tempary()
    {
        int age = 25;

        string msg = (age < 18) ? "You are a child" : "You are an adult";
    }

    }