using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�޼����� ����Ʈ �Ű�����(c������ �Լ��� default �μ��� ��)
//�Ű������� �⺻���� ���� �� �ִ�.
//�޼����� ȣ��� ���� ������ ������ ������ �⺻���� ����Ѵ�.


public class Test_02 : MonoBehaviour
{
    void Test(int AAA, bool isShow = true)
    {
        if (isShow == true)
        {

            int result = AAA;
            Debug.Log("Result" + result);
        }
        else
        {
            Debug.Log("Hide");
        }
    }

    //void Person(string Name)
    //{

    //    Debug.Log(Name);
    //}



    //void Person(string Name , int age) 
    //{

    //    Debug.Log(Name + ":" + age);
    //}

    //void Person(string Name, int age,string address)
    //{

    //Debug.Log(Name + ":" + age + ":"+ address);
    //}

    //�� �����ε� �ڵ带 ����Ʈ �Ű����� ������� �Ʒ��� ���� ���� �����ϴ�.

    void Person(string Name, int age = 0, string address = "")
    {
        string a_Temp = Name;
        if (0 < age)
            a_Temp += ":" + age;
        if (address != "")
            a_Temp += ":" + address;

        Debug.Log(a_Temp);
    }

    //����Ʈ �Ű������� �ڿ� �ִ� �Ű��������� ���� �ο��Ҽ��ְ� �߰��� �ǳʶۼ�����.

    void cacHap(int a_strat, int a_End = 100, int a_Add = 1)
    { 
        int a_Hap = 0;
        for(int i = a_strat; i < a_End; i += a_Add)
        {
            Debug.Log(a_Hap + "+" +  i + "="+ (a_Hap + i));
            a_Hap = a_Hap + i;
        }
    }
  

    // Start is called before the first frame update
    void Start()
    {
        Test( 1234, false);
        Test(4321); //�Ƚᵵ true���

        //���� ����? ---> ���� �Լ��� �ٲ��� �ʾƵ� �Ǵ� ������ �ִ�.
        Person("��ȣ");
        Person("��ȣ", 23);
        Person("��ȣ", 23, "����Ư����");


        //c# 4.0 ���� �����Ǵ� ���� �Ű�����
        Person("��ȣ", address: "����Ư����");
        Person("��ȣ", address: "����Ư����", age: 34);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
