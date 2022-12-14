
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{

    //2) Instanzvariable nutzen
    private int startV = 0;

    //3 Der Wert der dazugezählt wird ist bei Deklaration noch nicht bekannt
    // t.B: Random oder User Input
    private int startV3 = 0;

    //4) Copy by Value
    private int startV4 = 10;

    //5) Return
    private int startV5 = 20;

    //6) MyWork
    private string x = "before start Value:";
    private string y = "after start Value:";


    void Start()
    {
        Debug.Log("Hallo Methoden");


        //2) Instanzvariable nutzen
        Debug.Log(x + startV);
        IncrementByone();
        Debug.Log(y + startV);

        //ad 3)
        Debug.Log(x + startV3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log(y + startV3);

        //at 4)
        Debug.Log(x + startV4);
        OutputDecrementedValue(startV4);
        Debug.Log(y + startV4);


        //at 5)
        Debug.Log(x + startV5);
        startV5 = GetDifference(startV5, 2);
        Debug.Log(y + startV5);
    }
    
    //5)
    private int GetDifference(int a, int b) //Da Hol ma was
    {
        return a - b;
    }

    private void OutputDecrementedValue(int c)
    {
        c--;
        Debug.Log("val:" + c);
    }
   private void IncrementByX(int d) //Da bekommen wir wirklich was
   {
    startV3 += d;
   }
    
   private void IncrementByone()
    {
        startV++;
        //startValue = startValue +1;
    }
}
