using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Ŭ���� �Ҽ� ��� static(����) ����, (���� �޼���)
// <Ư¡>
// 1, ��ü ���� ���� Ŭ���� �̸�.������, Ŭ���� �̸�.�޼����()
//2,. ���α׷��� �����Ҷ� �޸𸮰� Ȯ���Ǽ� ���α׷��� ����ɶ����� �����Ѵ�,
//3. Ŭ���� �Ҽ������� Ŭ���� �Ҽ� �޸𸮸� ������ �����ϰ� �����Ѵ�,

public class Hero 
{
    public string m_Name; //�ν��Ͻ� �������(�Ϲ� �������)
    public int m_Hp;

    public static int s_UserPoint = 0; //���� �������(Ŭ���� �������)


    public void AddUserPoint(int a_Point)
    {
        s_UserPoint += a_Point;
    }
    public int GetUserPoint()
    { return s_UserPoint; }

    public static void StaticPrint() //���� ��� �޼���(Ŭ���� ��� �޼���)
    {
       /* m_Name = "�ȶ�";*/ //�Ϲ� ������� ����� ��������.
                            //--staticƯ���� �����ϸ� ���ѵ�,������ �ν��Ͻ� ������ �����µ� �����Ͱ� ������������ ��ü�� �̿��Ϸ��ϴ� �������°� �翬�ϴ�.

        int a_ABC = 100; //��������
        s_UserPoint = 1234; //���� ����������� ȣ���� ������ �߻������ʴ´�.
        Debug.Log(s_UserPoint);

    }
}//~public class Hero 

public class Test_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if KOREA
     Debug.Log ("�̰��� �ѱ۹����Դϴ�.");
#elif ENGLISH
     Debug.Log ("�̰��� ��������Դϴ�.");
#elif CHINA
     Debug.Log ("�̰��� �߱��� �����Դϴ�."); //�̷� ������ ������ �߱��� ��� ��� ���������༭ �Ҷ� define ���Ѽ� ����ְԵ�
        //���� ������ ���ε��� �ϸ� �ȵǴ� �ϳ��� ������Ʈ�� �ؼ� ���� ���ָ� ��.
#endif

        Hero.StaticPrint();   //��������޼��� ���
        Hero.s_UserPoint = 0; //����������� ���

        //����Ƽ���� �������ִ� static �޼��忹��

        Debug.Log("test");
        Random.Range(0, 100);
        Vector3 vector3 = Vector3.zero;//static ����

        //�� 3:3 ��� rpg�϶� 3���� �����ؼ� ���ӿ� �� ��Ȳ

        Hero AAA = new Hero();
        AAA.m_Name = "���۸�";
        AAA.m_Hp = 123;
        /*AAA.s_UserPoint = 1111; *///���� static ������ .��ü�� ��� �Ұ�
        Debug.Log(AAA.m_Name + ":" + AAA.m_Hp);
        AAA.AddUserPoint(100);
        //AAA.staticprint(); //���� �޼���� ��ü.���� �̿�Ұ�


        Hero BBB = new Hero();
        BBB.m_Name = "��Ʈ��";
        BBB.m_Hp = 98;
        Debug.Log(BBB.m_Name+ " :" + BBB.m_Hp);

        Hero CCC = new Hero();
        CCC.m_Name = "���̾��";
        CCC.m_Hp = 70;
        Debug.Log(CCC.m_Name + ": "+ CCC.m_Hp);
        CCC.AddUserPoint(30);

        Debug.Log(Hero.s_UserPoint + " :" + AAA.GetUserPoint() +
                  " : " + BBB.GetUserPoint() + " : " + CCC.GetUserPoint());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
