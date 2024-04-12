//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


////생성자 & 소멸자
////생성자 메서드
////클래스 이름과 똑같지만 리턴형이 없는 함수
////클래스 객체를 생성할때 자동으로 한번 호출되는 메서드
////언제쓰냐?--->멤버변수들을 초기화해주는 용도로 사용된다.


////~Student() //c#은 무조건 private(소멸자 메서드)
//        //~클래스 이름과 같은 함수
//        //객체의 메모리가 소멸될때 한번 자동호출되는 메서드

//    //언제 쓰냐? ---메모리 정리하고싶을때 헌데 가비지콜렉터가 많이 쓰인다.

////클래스에서는 생성자,소멸자를 생략할 수 있다.

////생략후 설계 하고 객체 만들면 자동으로 default 생성자가 생성됨

////생성자 오버로딩 함수만 만들고 기본 생성자만 생략시 default생성자의 자동생성이 끊긴다.



//public class Student
//{                                 //초기화 순서 시점 +     
//    public string m_Name = "";    //초기화 시점1
//    public int m_Jumsu = 0;       
//    public float m_Avg = 0.0f;

//    public Student() //생성자 메서드
//    {
//        //클래스 이름과 똑같지만 리턴형이 없는 함수
//        //클래스 객체를 생성할때 자동으로 한번 호출되는 메서드

//        //언제쓰냐?--->멤버변수들을 초기화해주는 용도로 사용된다.


//        Debug.Log("생성자 함수 호출");
//        m_Name = "학생1";                    //초기화 시점2
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

//    //--- 생성자 오버로딩 어디에 쓸까



//    ~Student() //c#은 무조건 private(소멸자 메서드) 삭제될때
//    {
//        //~클래스 이름과 같은 함수
//        //객체의 메모리가 소멸될때 한번 자동호출되는 메서드

//        //언제 쓰냐?
//        Debug.Log("소멸자 함수 호출");
//    }

//    public void printinfo() 
//    {

//    Debug.Log($"이름 {m_Name} 점수 ({m_Jumsu}) 평균({m_Avg}");
    
//    }
//}

//public class Test_02 : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
//       Student aaa = new Student();
//        aaa.m_Name = "전사";
//        aaa.m_Jumsu = 100;
//        aaa.m_Avg = 100.0f;                      //초기화 시점3
//        aaa.printinfo();

//        int BBB;    //1번타입
//        BBB = 111;
//        Debug.Log(BBB);


//        int CCC = 222;
//        Debug.Log (CCC);


//        Student a_st = new Student();
//        a_st.m_Name = "드래곤";
//        a_st.m_Jumsu = 87;
//        a_st.m_Avg = 70.3f;

//        a_st.printinfo();   


//        Student a_SS = new Student("힐러", 76 , 92.1f); //2번타입
//        a_SS.printinfo();


//        Student a_DDD = new Student("사냥꾼");
//        a_DDD.printinfo();



//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
