using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//C# namespace
//���� Ŭ���� �̸��� �ߺ��� ���ϱ� ���� Ŭ�������� �׷�ȭ�����ٶ� ���Ǵ� ����

public class item
{
    public string m_Nick;
    public int m_Star;
    public float m_AttRate;
}

    namespace Myclass
    {
    public class Item
    {
        public string m_Name;
        public int m_Level;
        public int m_Price;
    }



    } 

    namespace Myclass
    {
    public class monster
    {
        public string m_Nick;
        public int m_Hp;
    }
    }

public class Test_02 : MonoBehaviour
{
    public UnityEngine.UI.Button m_btn;
    public Text m_Text;


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






        item AAA = new item();
        AAA.m_Nick = "�ȶ��� ��";
        AAA.m_Star = 1;
        AAA.m_AttRate = 0.3f;
        Debug.Log(AAA.m_Nick + " : " + AAA.m_Star + " :" + AAA.m_AttRate);

        Myclass.Item BBB = new Myclass.Item();
        BBB.m_Name = "�巡���� ����";
        BBB.m_Level = 4;
        BBB.m_Price = 100;
        Debug.Log(BBB.m_Name + " : " + BBB.m_Level + " :" + AAA.m_AttRate);

        MyTeam.monster ccc = new MyTeam.monster();
        ccc.m_Name = "����";
        ccc.m_HP = 100;
        ccc.m_MP = 100;
        ccc.m_Attack = 100;
        ccc.PrinInfo();


        MyTeam.monster DDD = new MyTeam.monster();
        DDD.m_Name = "����";
        DDD.m_HP = 150;
        DDD.m_MP = 150;
        DDD.m_Attack = 30;
        DDD.PrinInfo();


        MyTeam.monster EEE = new MyTeam.monster();
        EEE.m_Name = "��ũ";
        EEE.m_HP = 200;
        EEE.m_MP = 200;
        EEE.m_Attack = 50;
        EEE.PrinInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
