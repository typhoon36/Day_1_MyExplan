using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//메서드의 디폴트 매개변수(c언어에서는 함수의 default 인수라 함)
//매개변수는 기본값을 가질 수 있다.
//메서드의 호출시 값의 전달이 없으면 정해진 기본값을 사용한다.


public class Test_02 : MonoBehaviour
{
    void Test(int AAA, bool isShow = true)
    {
        if (isShow == true)
        {

            int result = AAA;
            Debug.Log("Result" + result);
        }
        else
        {
            Debug.Log("Hide");
        }
    }

    //void Person(string Name)
    //{

    //    Debug.Log(Name);
    //}



    //void Person(string Name , int age) 
    //{

    //    Debug.Log(Name + ":" + age);
    //}

    //void Person(string Name, int age,string address)
    //{

    //Debug.Log(Name + ":" + age + ":"+ address);
    //}

    //위 오버로드 코드를 디폴트 매개변수 기능으로 아래와 같이 수정 가능하다.

    void Person(string Name, int age = 0, string address = "")
    {
        string a_Temp = Name;
        if (0 < age)
            a_Temp += ":" + age;
        if (address != "")
            a_Temp += ":" + address;

        Debug.Log(a_Temp);
    }

    //디폴트 매개변수는 뒤에 있는 매개변수부터 값을 부여할수있고 중간을 건너뛸수없다.

    void cacHap(int a_strat, int a_End = 100, int a_Add = 1)
    { 
        int a_Hap = 0;
        for(int i = a_strat; i < a_End; i += a_Add)
        {
            Debug.Log(a_Hap + "+" +  i + "="+ (a_Hap + i));
            a_Hap = a_Hap + i;
        }
    }
  

    // Start is called before the first frame update
    void Start()
    {
        Test( 1234, false);
        Test(4321); //안써도 true취급

        //언제 쓸까? ---> 기존 함수를 바꾸지 않아도 되는 장점이 있다.
        Person("민호");
        Person("민호", 23);
        Person("민호", 23, "서울특별시");


        //c# 4.0 부터 지원되는 명명된 매개변수
        Person("승호", address: "서울특별시");
        Person("승호", address: "서울특별시", age: 34);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
