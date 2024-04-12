using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneTemplate;
using UnityEngine;

//����ü(struct)
//���� ������ ���� ���� �������� ������� �޼������ ����(�Ƴ��α� ��)
// ����ü ��ü valuetype�̴�.
//����ü�� �ֿ뵵:��������� ������ ������ ���� �����ϴ� �� ���.
// ����ü�� ��ӵɼ�����

//Ŭ���� (class)
//���� ������ ���� ���� �������� ������� �޼������ ����(����Ʈ��)
//��ü�� ref type.
// Ŭ������ �ֿ뵵:����Ʈ ��� ��ǰȭ(��ü���� ���α׷���)�ϱ� ���� ������ ���.


//valule type ����-int float double struct(����ü)
//ref type ���� - array ,class ��ü 


//����ü(struct)
public struct Monster //����ü ����
{
    public string m_Name; //�������
    public int m_Hp;        //ü��       //c#������ ����ü���� public �Ӽ��� �����ϸ�
    public int m_Mp;        //����        // �⺻ �Ӽ��� private�̴�. 
    public int m_Level;     //����
    public float m_Attack;  //���ݷ�

    public void printInfo()     //c#�� Ư������ ��� �޼��� ���ǰ� ����
    {
        string str = $"{m_Name}   : ü��({m_Hp}) ���� ({m_Mp}) ����({m_Level}) ���ݷ� ({m_Attack.ToString("N2")})";
        Debug.Log(str);

    }
}

//Ŭ���� 
public class item  //Ŭ���� ����
{
    public string m_Name; //������ �̸� //�������
    public int m_Level; //������ ����
    public int m_Star;     // ������ ����
    public int m_Price;    // ������ ����
    float m_AttackRate = 1.0f; //���� ��·�
    //c# ���� �����ڸ� �����ϸ� �⺻���� private�Ӽ�
    public float AttackRate { get => m_AttackRate; 
        set => m_AttackRate = value; } //������Ƽ�� ���� ������ �б������̳� �������� �� ���� ó������ �ؼ�
                                       //������ �ܺ� �������κ��� ��ȣ�ϱ� ���ؼ� ����Ѵ�.

    //public float GetAttckRate()
    //{
    //    //����ȭ
    //    float temp = m_AttackRate;


    //    return temp; 
    //}

    public void setattackrate(float rate) //�߿亯���� ��ȣ
    {
        //��ȣȭ
        if (1.0f < rate)
            return;

        m_AttackRate = rate; 
    }



    public void PrintInfo()   //��� �޼���
    {
        string str = $"{m_Name} : ����({m_Level}) ����({m_Star}) ����({m_Price})  ���ݻ�·�({m_AttackRate.ToString("N2")}";
        Debug.Log(str);
    }

    public void copyitem(item a_item)  //�Ϲ��Լ��� �ƴ϶� �����ڷ� ����°� ���� ������
    {
        m_Name = a_item.m_Name;
        m_Level = a_item.m_Level;
        m_Star = a_item.m_Star;
        m_Price = a_item.m_Price;
    }

}

//���� ������ ������
//public : ����ü Ŭ���� ���ܺ� ��� ���� ������ �Ӽ�
//private: ����ü Ŭ���� ���ο����� ��밡���ϰ� �ܺο��� �����Ҽ����� �Ӽ�
//protected:  �ܺο��� �����Ҽ� ����,�ڽŰ� ��Ӱ����� �ڽ�Ŭ���������� ���� ����ϴ� �Ӽ�


public class Test_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Monster AAA; //����ü ���� ����
        AAA.m_Name = "��ũ";
        AAA.m_Hp = 100;
        AAA.m_Mp = 60;
        AAA.m_Level = 1;
        AAA.m_Attack = 2.5f;
        AAA.printInfo();

        Monster BBB; //����ü ���� ����
        BBB.m_Name = "����";
        BBB.m_Hp = 200;
        BBB.m_Mp = 80;
        BBB.m_Level = 5;
        BBB.m_Attack = 7.2f;
        BBB.printInfo();



        Monster CCC; //����ü ���� ����
        CCC.m_Name = "������";
        CCC.m_Hp = 110;
        CCC.m_Mp = 40;
        CCC.m_Level = 2;
        CCC.m_Attack = 0.4f;
        CCC.printInfo();

        //--����ü value type test

        Monster a_TestVal = AAA;
        //a_TestVal.m_Name = AAA.m_Name;
        //a_TestVal.m_Hp = AAA.m_Hp;
        //a_TestVal.m_Mp = AAA.m_Mp;    ----��� : ��� 1:1 ����(���� ���� : ��� �迭 ���� ���������� ����.)



        //a_TestVal.printInfo(); ----���⼱ ��ũ
        a_TestVal.m_Name = "���";
        a_TestVal.m_Hp = 999;
        a_TestVal.m_Mp = 999;
        a_TestVal.m_Level = 999;
        a_TestVal.m_Attack = 999;
        Debug.Log("------����ü value type test");
        AAA.printInfo();        // ��ũ
        a_TestVal.printInfo(); //----���
        Debug.Log("---------����ü value type test");




        //Ŭ���� ���� ����
        item a_MyItem = new item(); //Ŭ���� ������ ����, ��ü ����,�ν��Ͻ� ����
        //���ӿ� �̸� ��ġ�� ��� = ��ü , �ν��Ͻ� Ŭ���� ���� �����  
        a_MyItem.m_Name = "õ���� ����";
        a_MyItem.m_Level = 4;
        a_MyItem.m_Star = 2;
        a_MyItem.m_Price = 1200;
        //a_MyItem.m_attackrate = 1.1f; //private�Ӽ��� ��ü�� ���� �ܺο��� �����Ҽ�����.
        //a_MyItem.setattackrate(1.3f);
        //Debug.Log(a_MyItem.GetAttckRate());
        a_MyItem.PrintInfo();



        //Ŭ���� ref type test
        item a_TestRef = a_MyItem; //refŸ��
        a_TestRef.m_Name = "�巡���� ����";
        a_TestRef.m_Level = 999;
        a_TestRef.m_Star = 999;
        a_TestRef.m_Price = 999;

        Debug.Log("Ŭ���� ref type test");
        a_MyItem.PrintInfo();   //�巡���� ������ ���
        a_TestRef.PrintInfo();  //�巡���� ������ ���
        Debug.Log("Ŭ���� ref type test");

        //int[] abc = { 11 };
        //int[] xyz = abc;
        //xyz[0] = 999;
        //Debug.Log(abc[0] + " : " + xyz[0]); //999 : 999

        //Ŭ������ ���������θ� ������ �ƴ϶� �ֵ��� ���纻 ��ü�� "����" �������� ���

       item xxx= new item();
        xxx.m_Name = a_MyItem.m_Name;
        xxx.m_Level = a_MyItem.m_Level;
        xxx.m_Star = a_MyItem.m_Star;
        xxx.m_Price = a_MyItem.m_Price;
        //xxx.copyitem(a_MyItem);
        //���� ����:��������ڰ��� �Լ������� ��� ���� �߿� �迭ó�� �������� ���� ���� �����Ͽ� �ش簪�� �����ϴ� ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}