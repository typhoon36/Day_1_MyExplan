using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hero.StaticPrint();
         Hero.s_UserPoint = 11;
         


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
