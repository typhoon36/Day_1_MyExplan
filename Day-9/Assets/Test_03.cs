using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneTemplate;
using UnityEngine;

//구조체(struct)
//같은 목적을 갖는 여러 데이터형 변수들과 메서드들의 집합(아날로그 폰)
// 구조체 객체 valuetype이다.
//구조체의 주용도:상대적으로 간략한 데이터 값을 저장하는 데 사용.
// 구조체는 상속될수없음

//클래스 (class)
//같은 목적을 갖는 여러 데이터형 변수들과 메서드들의 집합(스마트폰)
//객체는 ref type.
// 클래스의 주용도:소프트 웨어를 부품화(객체지향 프로그래밍)하기 위한 도구로 사용.


//valule type 변수-int float double struct(구조체)
//ref type 변수 - array ,class 객체 


//구조체(struct)
public struct Monster //구조체 설계
{
    public string m_Name; //멤버변수
    public int m_Hp;        //체력       //c#에서는 구조체에서 public 속성을 생략하면
    public int m_Mp;        //마나        // 기본 속성인 private이다. 
    public int m_Level;     //레벨
    public float m_Attack;  //공격력

    public void printInfo()     //c#의 특성으로 멤버 메서드 정의가 가능
    {
        string str = $"{m_Name}   : 체력({m_Hp}) 마나 ({m_Mp}) 레벨({m_Level}) 공격력 ({m_Attack.ToString("N2")})";
        Debug.Log(str);

    }
}

//클래스 
public class item  //클래스 설계
{
    public string m_Name; //아이템 이름 //멤버변수
    public int m_Level; //아이템 레벨
    public int m_Star;     // 아이템 성급
    public int m_Price;    // 아이템 가격
    float m_AttackRate = 1.0f; //공격 상승률
    //c# 접근 수식자를 생략하면 기본값은 private속성
    public float AttackRate { get => m_AttackRate; 
        set => m_AttackRate = value; } //프로퍼티를 쓰는 이유는 읽기전용이나 쓰기전용 값 제한 처리등을 해서
                                       //변수를 외부 접근으로부터 보호하기 위해서 사용한다.

    //public float GetAttckRate()
    //{
    //    //복보화
    //    float temp = m_AttackRate;


    //    return temp; 
    //}

    public void setattackrate(float rate) //중요변수를 보호
    {
        //암호화
        if (1.0f < rate)
            return;

        m_AttackRate = rate; 
    }



    public void PrintInfo()   //멤버 메서드
    {
        string str = $"{m_Name} : 레벨({m_Level}) 성급({m_Star}) 가격({m_Price})  공격상승률({m_AttackRate.ToString("N2")}";
        Debug.Log(str);
    }

    public void copyitem(item a_item)  //일반함수가 아니라 생성자로 만드는걸 복사 생성자
    {
        m_Name = a_item.m_Name;
        m_Level = a_item.m_Level;
        m_Star = a_item.m_Star;
        m_Price = a_item.m_Price;
    }

}

//접근 수식자 지정자
//public : 구조체 클래스 내외부 모두 접근 가능한 속성
//private: 구조체 클래스 내부에서만 사용가능하고 외부에서 접근할수없는 속성
//protected:  외부에서 접근할수 없음,자신과 상속관계의 자식클래스까지는 접근 허용하는 속성


public class Test_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Monster AAA; //구조체 변수 선언
        AAA.m_Name = "오크";
        AAA.m_Hp = 100;
        AAA.m_Mp = 60;
        AAA.m_Level = 1;
        AAA.m_Attack = 2.5f;
        AAA.printInfo();

        Monster BBB; //구조체 변수 선언
        BBB.m_Name = "울프";
        BBB.m_Hp = 200;
        BBB.m_Mp = 80;
        BBB.m_Level = 5;
        BBB.m_Attack = 7.2f;
        BBB.printInfo();



        Monster CCC; //구조체 변수 선언
        CCC.m_Name = "슬라임";
        CCC.m_Hp = 110;
        CCC.m_Mp = 40;
        CCC.m_Level = 2;
        CCC.m_Attack = 0.4f;
        CCC.printInfo();

        //--구조체 value type test

        Monster a_TestVal = AAA;
        //a_TestVal.m_Name = AAA.m_Name;
        //a_TestVal.m_Hp = AAA.m_Hp;
        //a_TestVal.m_Mp = AAA.m_Mp;    ----멤버 : 멤버 1:1 복사(얕은 복사 : 멤버 배열 같은 참조변수도 같다.)



        //a_TestVal.printInfo(); ----여기선 오크
        a_TestVal.m_Name = "상어";
        a_TestVal.m_Hp = 999;
        a_TestVal.m_Mp = 999;
        a_TestVal.m_Level = 999;
        a_TestVal.m_Attack = 999;
        Debug.Log("------구조체 value type test");
        AAA.printInfo();        // 오크
        a_TestVal.printInfo(); //----상어
        Debug.Log("---------구조체 value type test");




        //클래스 변수 선언
        item a_MyItem = new item(); //클래스 변수의 선언, 객체 선언,인스턴스 선언
        //게임에 미리 설치된 재료 = 객체 , 인스턴스 클래스 내에 선언된  
        a_MyItem.m_Name = "천사의 반지";
        a_MyItem.m_Level = 4;
        a_MyItem.m_Star = 2;
        a_MyItem.m_Price = 1200;
        //a_MyItem.m_attackrate = 1.1f; //private속성은 객체를 통해 외부에서 접근할수없다.
        //a_MyItem.setattackrate(1.3f);
        //Debug.Log(a_MyItem.GetAttckRate());
        a_MyItem.PrintInfo();



        //클래스 ref type test
        item a_TestRef = a_MyItem; //ref타입
        a_TestRef.m_Name = "드래곤의 반지";
        a_TestRef.m_Level = 999;
        a_TestRef.m_Star = 999;
        a_TestRef.m_Price = 999;

        Debug.Log("클래스 ref type test");
        a_MyItem.PrintInfo();   //드래곤의 반지로 출력
        a_TestRef.PrintInfo();  //드래곤의 반지로 출력
        Debug.Log("클래스 ref type test");

        //int[] abc = { 11 };
        //int[] xyz = abc;
        //xyz[0] = 999;
        //Debug.Log(abc[0] + " : " + xyz[0]); //999 : 999

        //클래스를 참조변수로만 대입이 아니라 쌍둥이 복사본 객체를 "따로" 만들고싶은 경우

       item xxx= new item();
        xxx.m_Name = a_MyItem.m_Name;
        xxx.m_Level = a_MyItem.m_Level;
        xxx.m_Star = a_MyItem.m_Star;
        xxx.m_Price = a_MyItem.m_Price;
        //xxx.copyitem(a_MyItem);
        //깊은 복사:복사생성자같은 함수를통해 멤버 변수 중에 배열처럼 참조형의 변수 값을 추적하여 해당값을 복사하는 방식
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}