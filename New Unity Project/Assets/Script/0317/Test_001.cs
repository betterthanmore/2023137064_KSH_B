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

        Debug.Log('��');
        Debug.Log('A');
        Debug.Log('��');

        Debug.Log("�ȳ��ϼ���");

        Debug.Log("������" + "��" + "�ٻ��" + "����īŸ" + "����");

        Debug.Log("�ȳ��ϼ���"[0]);
        Debug.Log("�ȳ��ϼ���"[1]);
        Debug.Log("�ȳ��ϼ���"[2]);
        Debug.Log("�ȳ��ϼ���"[100]);

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
