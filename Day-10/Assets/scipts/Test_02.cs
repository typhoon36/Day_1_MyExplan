//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


////������ & �Ҹ���
////������ �޼���
////Ŭ���� �̸��� �Ȱ����� �������� ���� �Լ�
////Ŭ���� ��ü�� �����Ҷ� �ڵ����� �ѹ� ȣ��Ǵ� �޼���
////��������?--->����������� �ʱ�ȭ���ִ� �뵵�� ���ȴ�.


////~Student() //c#�� ������ private(�Ҹ��� �޼���)
//        //~Ŭ���� �̸��� ���� �Լ�
//        //��ü�� �޸𸮰� �Ҹ�ɶ� �ѹ� �ڵ�ȣ��Ǵ� �޼���

//    //���� ����? ---�޸� �����ϰ������ �嵥 �������ݷ��Ͱ� ���� ���δ�.

////Ŭ���������� ������,�Ҹ��ڸ� ������ �� �ִ�.

////������ ���� �ϰ� ��ü ����� �ڵ����� default �����ڰ� ������

////������ �����ε� �Լ��� ����� �⺻ �����ڸ� ������ default�������� �ڵ������� �����.



//public class Student
//{                                 //�ʱ�ȭ ���� ���� +     
//    public string m_Name = "";    //�ʱ�ȭ ����1
//    public int m_Jumsu = 0;       
//    public float m_Avg = 0.0f;

//    public Student() //������ �޼���
//    {
//        //Ŭ���� �̸��� �Ȱ����� �������� ���� �Լ�
//        //Ŭ���� ��ü�� �����Ҷ� �ڵ����� �ѹ� ȣ��Ǵ� �޼���

//        //��������?--->����������� �ʱ�ȭ���ִ� �뵵�� ���ȴ�.


//        Debug.Log("������ �Լ� ȣ��");
//        m_Name = "�л�1";                    //�ʱ�ȭ ����2
//        m_Jumsu = 1;
//        m_Avg = 1.0f;

//    }

//    public Student (string name)
//    {
//        m_Name = name;

//    }


//    public Student(string name, int jumsu, float avg)
//    {
//        m_Name = name;
//        m_Jumsu = jumsu;
//        m_Avg = avg;
//    }

//    //--- ������ �����ε� ��� ����



//    ~Student() //c#�� ������ private(�Ҹ��� �޼���) �����ɶ�
//    {
//        //~Ŭ���� �̸��� ���� �Լ�
//        //��ü�� �޸𸮰� �Ҹ�ɶ� �ѹ� �ڵ�ȣ��Ǵ� �޼���

//        //���� ����?
//        Debug.Log("�Ҹ��� �Լ� ȣ��");
//    }

//    public void printinfo() 
//    {

//    Debug.Log($"�̸� {m_Name} ���� ({m_Jumsu}) ���({m_Avg}");
    
//    }
//}

//public class Test_02 : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
//       Student aaa = new Student();
//        aaa.m_Name = "����";
//        aaa.m_Jumsu = 100;
//        aaa.m_Avg = 100.0f;                      //�ʱ�ȭ ����3
//        aaa.printinfo();

//        int BBB;    //1��Ÿ��
//        BBB = 111;
//        Debug.Log(BBB);


//        int CCC = 222;
//        Debug.Log (CCC);


//        Student a_st = new Student();
//        a_st.m_Name = "�巡��";
//        a_st.m_Jumsu = 87;
//        a_st.m_Avg = 70.3f;

//        a_st.printinfo();   


//        Student a_SS = new Student("����", 76 , 92.1f); //2��Ÿ��
//        a_SS.printinfo();


//        Student a_DDD = new Student("��ɲ�");
//        a_DDD.printinfo();



//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
