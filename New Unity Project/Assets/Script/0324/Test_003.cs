using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;

    void Start()
    {
        int herbNum = 1;

        if ( herbNum == 1 )
        {
            Debug.Log("체력을 50 회복");
        }
        else 
        {
            Debug.Log("체력 -50");
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
