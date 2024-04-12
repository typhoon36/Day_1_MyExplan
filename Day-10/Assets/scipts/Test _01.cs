using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//구조체 Value Type과 클래스 Reference Type : 메서드의 매개변수로 사용될 때의 특징

// 구조체 (struct)
public struct Monster  //<-- 구조체 설계
{
    public string m_Name;   //<-- 맴버변수
    public int m_Hp;        //체력         //C#에서는 구조체에서 public 속성을 생략하면
    public int m_Mp;        //마나         //기본 속성은 private 속성이 된다.
    public int m_Level;     //레벨
    public float m_Attack;  //공격력

    public void PrintInfo()  //<-- 맴버 메서드 정의
    {
        string str = $"{m_Name} : 체력({m_Hp}) 마나({m_Mp}) 레벨({m_Level}) 공격력({m_Attack.ToString("N2")})";
        Debug.Log(str);
    }
} //public struct Monster

// 클래스 (class)
public class Item       //<-- 클래스 설계
{
    public string m_Name;   //아이템 이름  //<-- 맴버변수
    public int m_Level;     //아이템 레벨
    public int m_Star;      //아이템 성급
    public int m_Price;     //아이테 가격
    float m_AttackRate = 1.0f;  //아이템 공격 상승률
    //C#에서는 접근수식자를 생략하면 기본값을 private 속성이다.
    //프로퍼티를 쓰는 이유는 읽기전용이나, 쓰기전용 또는 값 제한 처리 등을 해서 변수를 외부 접근으로부터 보호하기
    //위해서 사용한다.
    //public float AttackRate { get => m_AttackRate; set => m_AttackRate = value; } //속성, 프로퍼티 property
    //public float AttackRate {
    //    get { 
    //        return m_AttackRate; 
    //    }
    //    set {

    //        if (1.0f < value)
    //            return;
    //        m_AttackRate = value; 
    //    } 
    //} //속성, 프로퍼티 property

    public float GetAttackRate()
    {
        float Temp = m_AttackRate;

        //복호화
        return Temp;
    }

    public void SetAttackRate(float rate)
    {
        //암호화
        if (1.0f < rate)
            return;
        m_AttackRate = rate;
    }

    public void PrintInfo()   //<-- 맴버메서드
    {
        string str = $"{m_Name} : 레벨({m_Level}) 성급({m_Star}) " +
                     $"가격({m_Price}) 공격상승률({m_AttackRate.ToString("N2")}";
        Debug.Log(str);
    }

    public void CopyItem(Item a_item)  //<-- 일반함수가 아니라 생성자로 만드는 걸 "복사생성자"라고 한다.
    {
        m_Name = a_item.m_Name;
        m_Level = a_item.m_Level;
        m_Star = a_item.m_Star;
        m_Price = a_item.m_Price;
        m_AttackRate = a_item.GetAttackRate();
    }
}

public class Test_01 : MonoBehaviour
{
    public void Value(int aa)
    {
        aa = 1000;
    }

    public void Reference(int[] aa)
    {
        aa[0] = 1000;
    }

    //--- 구조체를 매개변수로 받는 함수
    public void MonsterMethod(Monster a_Mon)
    {
        a_Mon.m_Name = "벨류구조체";
        a_Mon.m_Level = 999;
        a_Mon.m_Hp = 999;
        a_Mon.m_Mp = 999;
        a_Mon.m_Attack = 999.9f;
    }

    //--- 클래스를 매개변수로 받는 함수
    public void ItemMethod(Item a_It)
    {
        a_It.m_Name = "레퍼런스클래스";
        a_It.m_Level = 999;
        a_It.m_Star = 999;
        a_It.m_Price = 999;
    }

    // Start is called before the first frame update
    void Start()
    {
        int xx = 0;
        Value(xx);
        Debug.Log("xx : " + xx);     // 0

        int[] yy = { 0 };
        Reference(yy);
        Debug.Log("yy : " + yy[0]);  // 1000

        //--- 구조체 (Value Type)
        Monster AAA;
        AAA.m_Name = "드래곤";
        AAA.m_Level = 0;
        AAA.m_Hp = 0;
        AAA.m_Mp = 0;
        AAA.m_Attack = 0.0f;
        MonsterMethod(AAA);
        AAA.PrintInfo();

        //--- 클래스 (Reference Type)
        Item BBB = new Item();
        BBB.m_Name = "천사의 반지";
        BBB.m_Level = 0;
        BBB.m_Star = 0;
        BBB.m_Price = 0;
        ItemMethod(BBB);
        BBB.PrintInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
   
