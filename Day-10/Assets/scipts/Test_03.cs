using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

//ref type -�迭 Ŭ���� 
//value type = int float struc
//ref out = value type �������� ref typeó�� ���۽����ִ� Ű����
//ref :������(�Ű������� �Ѱܹ��� ������ �޼��� �ȿ��� ��������ʾƵ� �ȴ�.)
//out  ������(�Ű������� �Ѱܹ��� ������ �޼��� �ȿ��� �ݵ�� ����Ѵ�.)

public class Test_03 : MonoBehaviour
{
    void valueMethod(int a_ii)
    {
        a_ii = 1000;          
        Debug.Log("test" + a_ii);

    }

    void RefMethod(ref int a_ii)   //refŰ����� ���� �μ��� �޼��� �ȿ��� ���� ���������ʾƵ� �ȴ�.(�ص� �ǰ� ���ص� �ǰ�:�̰� ������)
    {                              
        a_ii= 1000; 
        Debug.Log ("test" + a_ii);
    }

    void OutMethod(out int a_ii)  //OUT�� �ȵ� �ݵ�� ���Խ��Ѿ� ��.
    {
        a_ii = 1000;
        //Debug.Log("TEST" + a_ii);
    }

    bool add (int a, int b ,ref int x , ref float y , ref long z)
    {
        //x = 0;
        //y = 0.0f;
        //z = 0L;
        if(x< 0)
        {
            return false;
        }
        x = x + 100;
        y = x * 2.5f;
        z = x * 10000;

        return true;

    }


    // Start is called before the first frame update
    void Start()
    {
        int aaa = 0;
        int bbb = aaa;
        bbb = 999;
        Debug.Log(aaa + " : " +bbb); // 0 : 999


        int xxx = 0;
        ref int vvv = ref xxx;
        ref int yyy = ref xxx;
        ref int zzz = ref xxx;
        vvv = 999;
        Debug.Log(xxx + " : " +vvv + ":" + yyy + ":" + zzz);

        int ccc = 0;
        valueMethod(ccc);
        Debug.Log("ccc : " +  ccc);  //0


        int eee = 0;
        RefMethod(ref eee);
        Debug.Log("eee  : " + eee);  //1000

        int fff = 0;
        OutMethod (out fff);
        Debug.Log("fff : " + fff); //1000

        int a_Int = 5;
        float a_Float = 0.0f;
        long a_Loint = 0L;
       if (add(1,2,ref a_Int,ref a_Float,ref a_Loint) == true)
        {
            Debug.Log(a_Int + " : "+a_Float +" : "+a_Loint);
        }

        string a_mm = "123.456";
        float a_rst = 0.0f;
        bool isOk = float.TryParse(a_mm, out a_rst);
        if (isOk == true)
        {
            Debug.Log("a_rst : " + a_rst);
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
