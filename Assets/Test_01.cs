using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("1부터 10까지 합구하기");

        //int sum = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(sum + i + "=" + sum + "+" + i);
        //    sum += i;
        //}

        Debug.Log("1부터 10까지 합구하기");
        int sum = 0;
        for(int i = 0;i < 10;i++)
        {
            sum += i;
            Debug.Log((sum-i) + i + "=" + sum);
        }

    }

 

    // Update is called once per frame
    void Update()
    {
        
    }
}
