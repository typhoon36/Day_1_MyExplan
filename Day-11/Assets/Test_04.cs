using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity C# ���� �ε� PlayerPrefabs

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
            PlayerPrefs.SetString("NickName", "�ȶ�");
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

            Debug.Log("���� : " + a_Nick + ", ��� :" + a_UserGold
                + ",����" + a_UserLevel + ", ���ݷ� : " + a_AttackRate);
        }

        if(Input.GetKey(KeyCode.C)==true) 
        {
            PlayerPrefs.DeleteAll(); //����� ��� ������ ����������
            //PlayerPrefs.DeleteKey("userlevel"); Ư�� Ű �� �ʱ�ȭ

        }
    }
}
