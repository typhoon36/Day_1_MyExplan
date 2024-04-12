using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//C# namespace
//같은 클래스 이름의 중복을 피하기 위해 클래스들을 그룹화시켜줄때 사용되는 문법

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
     Debug.Log ("이것은 한글버젼입니다.");
#elif ENGLISH
     Debug.Log ("이것은 영어버젼입니다.");
#elif CHINA
     Debug.Log ("이것은 중국어 버젼입니다."); //이런 식으로 영어대사 중국어 대사 등등 번역시켜줘서 할때 define 시켜서 띄워주게됨
        //만약 버전을 따로따로 하면 안되니 하나의 프로젝트를 해서 관리 해주면 됨.
#endif






        item AAA = new item();
        AAA.m_Nick = "팔라독의 검";
        AAA.m_Star = 1;
        AAA.m_AttRate = 0.3f;
        Debug.Log(AAA.m_Nick + " : " + AAA.m_Star + " :" + AAA.m_AttRate);

        Myclass.Item BBB = new Myclass.Item();
        BBB.m_Name = "드래곤의 방패";
        BBB.m_Level = 4;
        BBB.m_Price = 100;
        Debug.Log(BBB.m_Name + " : " + BBB.m_Level + " :" + AAA.m_AttRate);

        MyTeam.monster ccc = new MyTeam.monster();
        ccc.m_Name = "늑대";
        ccc.m_HP = 100;
        ccc.m_MP = 100;
        ccc.m_Attack = 100;
        ccc.PrinInfo();


        MyTeam.monster DDD = new MyTeam.monster();
        DDD.m_Name = "좀비";
        DDD.m_HP = 150;
        DDD.m_MP = 150;
        DDD.m_Attack = 30;
        DDD.PrinInfo();


        MyTeam.monster EEE = new MyTeam.monster();
        EEE.m_Name = "오크";
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
