using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity C# 저장 로딩 PlayerPrefabs

public class Test_04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)==true)
        { //save
            PlayerPrefs.SetString("NickName", "팔라독");
            PlayerPrefs.SetInt("UserGold", 120);
            PlayerPrefs.SetInt("UserLevel", 11 );
            PlayerPrefs.SetFloat("AttackRate", 0.57f);


        }
        if(Input.GetKeyDown (KeyCode.L)==true)
        { //loading.
            string a_Nick = PlayerPrefs.GetString("NickName", "");
            int a_UserGold = PlayerPrefs.GetInt("UserGold", 0);
            int a_UserLevel = PlayerPrefs.GetInt("UserLevel", 0);
            float a_AttackRate = PlayerPrefs.GetFloat("AttackRate", 0.0f);

            Debug.Log("별명 : " + a_Nick + ", 골드 :" + a_UserGold
                + ",레벨" + a_UserLevel + ", 공격력 : " + a_AttackRate);
        }

        if(Input.GetKey(KeyCode.C)==true) 
        {
            PlayerPrefs.DeleteAll(); //저장된 모든 정보를 삭제시켜줌
            //PlayerPrefs.DeleteKey("userlevel"); 특정 키 값 초기화

        }
    }
}
