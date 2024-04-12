using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//메서드 오버로딩(함수의 오버로딩)
//하나의 메서드 이름으로 여러개의 메서드를 구현하는것.
//매개변수의 형식만 다르면 같은 메서드 이름을 이용할수있다.
//하나의 함수 이름으로 다양한 데이터형 매개변수를 편하게 사용하기위해서 사용되는 문법



public class Test_01 : MonoBehaviour
{
    int Plus (int a, int b)
    {
        return a + b;
    }

    //double Plus(int a,int b) //매개변수의 형식이 같은 메서드 이름이 이미 정의 
    //{
    //    return (a + b);
    //}


    double Plus(double a, double b) //1.메서드 오버로딩의 예
    {
        return (a + b);
    }

    int Plus(int a, int b,int c) //2.메서드 오버로딩의 예(매개변수의 개수가 다름)
    {
        return a + b + c;
    }

    double Plus(int a, double b)  //3
    {
        return (a+b);
    }


    // Start is called before the first frame update
    void Start()
    {
        int ret = Plus(45, 70);

        Debug.Log(Plus(1.8, 2.4));
        Debug.Log(Plus(40, 70, 90));
        Debug.Log(Plus(1, 2.4));


        //유니티 C#에서 지원하는 메소드 오버로딩

        int iRan = Random.Range(1, 7);   //1~6 랜덤값을 발생
        Debug.Log(iRan);

        float fRan = Random.Range(1.5f, 3.14f); //1.5~3.14f 랜덤값.
        Debug.Log(fRan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
