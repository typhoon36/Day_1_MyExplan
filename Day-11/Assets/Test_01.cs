using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//클래스 소속 멤버 static(정적) 변수, (정적 메서드)
// <특징>
// 1, 객체 생성 없이 클래스 이름.변수명, 클래스 이름.메서드명()
//2,. 프로그램이 시작할때 메모리가 확보되서 프로그램이 종료될때까지 유지한다,
//3. 클래스 소속이지만 클래스 소속 메모리를 별도로 생성하고 종료한다,

public class Hero 
{
    public string m_Name; //인스턴스 멤버변수(일반 멤버변수)
    public int m_Hp;

    public static int s_UserPoint = 0; //정적 멤버변수(클래스 멤버변수)


    public void AddUserPoint(int a_Point)
    {
        s_UserPoint += a_Point;
    }
    public int GetUserPoint()
    { return s_UserPoint; }

    public static void StaticPrint() //정적 멤버 메서드(클래스 멤버 메서드)
    {
       /* m_Name = "팔라독";*/ //일반 멤버변수 사용은 에러난다.
                            //--static특성을 생각하면 편한데,이유가 인스턴스 변수로 쓰려는데 데이터가 생성되지않은 객체를 이용하려하니 에러나는게 당연하다.

        int a_ABC = 100; //지역변수
        s_UserPoint = 1234; //정적 멤버변수끼리 호출은 문제가 발생하지않는다.
        Debug.Log(s_UserPoint);

    }
}//~public class Hero 

public class Test_01 : MonoBehaviour
{
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

        Hero.StaticPrint();   //정적멤버메서드 사용
        Hero.s_UserPoint = 0; //정적멤버변수 사용

        //유니티에서 제공해주는 static 메서드예시

        Debug.Log("test");
        Random.Range(0, 100);
        Vector3 vector3 = Vector3.zero;//static 변수

        //턴 3:3 방식 rpg일때 3명을 선택해서 게임에 들어간 상황

        Hero AAA = new Hero();
        AAA.m_Name = "슈퍼맨";
        AAA.m_Hp = 123;
        /*AAA.s_UserPoint = 1111; *///에러 static 변수는 .객체로 사용 불가
        Debug.Log(AAA.m_Name + ":" + AAA.m_Hp);
        AAA.AddUserPoint(100);
        //AAA.staticprint(); //에러 메서드는 객체.으로 이용불가


        Hero BBB = new Hero();
        BBB.m_Name = "배트맨";
        BBB.m_Hp = 98;
        Debug.Log(BBB.m_Name+ " :" + BBB.m_Hp);

        Hero CCC = new Hero();
        CCC.m_Name = "아이언맨";
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
