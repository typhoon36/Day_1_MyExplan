using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�޼��� �����ε�(�Լ��� �����ε�)
//�ϳ��� �޼��� �̸����� �������� �޼��带 �����ϴ°�.
//�Ű������� ���ĸ� �ٸ��� ���� �޼��� �̸��� �̿��Ҽ��ִ�.
//�ϳ��� �Լ� �̸����� �پ��� �������� �Ű������� ���ϰ� ����ϱ����ؼ� ���Ǵ� ����



public class Test_01 : MonoBehaviour
{
    int Plus (int a, int b)
    {
        return a + b;
    }

    //double Plus(int a,int b) //�Ű������� ������ ���� �޼��� �̸��� �̹� ���� 
    //{
    //    return (a + b);
    //}


    double Plus(double a, double b) //1.�޼��� �����ε��� ��
    {
        return (a + b);
    }

    int Plus(int a, int b,int c) //2.�޼��� �����ε��� ��(�Ű������� ������ �ٸ�)
    {
        return a + b + c;
    }

    double Plus(int a, double b)  //3
    {
        return (a+b);
    }


    // Start is called before the first frame update
    void Start()
    {
        int ret = Plus(45, 70);

        Debug.Log(Plus(1.8, 2.4));
        Debug.Log(Plus(40, 70, 90));
        Debug.Log(Plus(1, 2.4));


        //����Ƽ C#���� �����ϴ� �޼ҵ� �����ε�

        int iRan = Random.Range(1, 7);   //1~6 �������� �߻�
        Debug.Log(iRan);

        float fRan = Random.Range(1.5f, 3.14f); //1.5~3.14f ������.
        Debug.Log(fRan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
