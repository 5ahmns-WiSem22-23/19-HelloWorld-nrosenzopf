using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{

    // Zuweisungsoperatoren
    public int a = 5;
    public int b = 3;

    void Start()
    {

        // Gleichheitsoperatoan
        bool c = a == b;
        Debug.Log(c);
        c = a != b;
        Debug.Log(c);

        // Vergleichsoperatoren
        c = a > b;
        Debug.Log(c);
        c = a >= b;
        Debug.Log(c);
        c = a < b;
        Debug.Log(c);
        c = a <= b;
        Debug.Log(c);


        // Arithmetische Operatoren
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);



        // Logische Operatoren
        bool d = true;
        bool e = false;
        Debug.Log(d && e);
        Debug.Log(d || e);
        Debug.Log(!d);

        // In Statements
        if (a > b)
        {
            Debug.Log("a ist größer als b");
        }

        if (a < b)
        {
            Debug.Log("b ist größer als a");
        }

        if (a == b)
        {
            Debug.Log("a ist gleich b");
        }
        else if (a != b)
        {
            Debug.Log("a ist nicht gleich b");
        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i +1);
        }

       

    }
}
