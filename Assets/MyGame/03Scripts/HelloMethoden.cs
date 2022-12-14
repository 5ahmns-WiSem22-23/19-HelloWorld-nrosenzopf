
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{

    //2) Instanzvariable nutzen
    private int startValue = 0;

    //3 Der Wert der dazugezählt wird ist bei Deklaration noch nicht bekannt
    // t.B: Random oder User Input
    private int startValue3 = 0;

    //4) Copy by Value
    private int startValue4 = 10;

    //5) Return
    private int startValue5 = 20;


    void Start()
    {
        Debug.Log("Hallo Methoden");


        //2) Instanzvariable nutzen
        Debug.Log("before startValue:" + startValue);
        IncrementByone();
        Debug.Log("after startValue:" + startValue);

        //ad 3)
        Debug.Log("before startValue:" + startValue3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after start Value:" + startValue3);

        //at 4)
        Debug.Log("before startValue:" + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after start Value:" + startValue4);


        //at 5)
        Debug.Log("before startValue:" + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after start Value:" + startValue5);
    }
    
    //5)
    private int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val:" + val);
    }
   private void IncrementByX(int valToAdd)
   {
    startValue3 += valToAdd;
   }
    
   private void IncrementByone()
    {
        startValue++;
        //startValue = startValue +1;
    }
}
