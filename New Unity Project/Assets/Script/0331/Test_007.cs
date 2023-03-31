using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    // Start is called before the first frame update
    void SayHello()
    {
        Debug.Log("=======================================");
        Debug.Log("Hello");
        Debug.Log("=======================================");
    }



    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }


    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    // Update is called once per frame
    void start()
    {
        //SayHello();
        //SayHello();
        //SayHello();

        CallName("Tom");
        CallName("Harry");
        CallName("Lora");

        int anwwer;
        anwwer = Add(2, 3);
        Debug.Log(anwwer);
    }
}
