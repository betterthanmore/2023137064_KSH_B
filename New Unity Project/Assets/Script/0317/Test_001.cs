using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(1.0 + 2.0);
        Debug.Log(1.0 - 2.0);
        Debug.Log(1.0 * 2.0);
        Debug.Log(1.0 / 2.0);

        Debug.Log('가');
        Debug.Log('A');
        Debug.Log('나');

        Debug.Log("안녕하세요");

        Debug.Log("가나다" + "라마" + "바사아" + "자차카타" + "파하");

        Debug.Log("안녕하세요"[0]);
        Debug.Log("안녕하세요"[1]);
        Debug.Log("안녕하세요"[2]);
        Debug.Log("안녕하세요"[100]);

        Debug.Log(true);
        Debug.Log(false);
        Debug.Log(2002 < 2021);
        Debug.Log(2002 > 2021);

        Debug.Log(!true);
        Debug.Log(!false);

        Debug.Log( !(2002 < 2021));
        Debug.Log( !(2002 > 2021));

        int nowHour = 11;

        Debug.Log(nowHour < 10 || 12 < nowHour);
        //Debug.Log(10 < nowHour && < 12);


    }

}
