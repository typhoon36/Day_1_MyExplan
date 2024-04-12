using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Student
{
    public string m_Name;
    public int m_Kor;
    public int m_Eng;
    public int m_Math;
    public int m_Total;
    public float m_Avg;

    //������ �����ε� �Լ�
    public Student(string a_Name = "", int a_Kor = 0, int a_Eng = 0, int a_Math = 0)
    {
        m_Name = a_Name;
        m_Kor = a_Kor;
        m_Eng = a_Eng;
        m_Math = a_Math;

        m_Total = m_Kor + m_Eng + m_Math;
        m_Avg = m_Total / 3.0f;
    }

    public string PrintInfo()
    {
        string a_Result = "";

        a_Result = $"{m_Name} : ����({m_Kor}) ����({m_Eng}) ����({m_Math})\n\n";
        a_Result += $"����({m_Total}) ���({m_Avg.ToString("N2")})\n\n";

        if (80.0f <= m_Avg)
        {
            a_Result += "<Color=#ff00ff>";
            a_Result += m_Name + " �л��� A����Դϴ�.";
            a_Result += "</Color>";
        }
        else if (60.0f <= m_Avg)
        {
            a_Result += "<Color=#ff0000>";
            a_Result += m_Name + " �л��� B����Դϴ�.";
            a_Result += "</Color>";
        }
        else if (40.0f <= m_Avg)
        {
            a_Result += "<Color=#00ff00>";
            a_Result += m_Name + " �л��� C����Դϴ�.";

        }
        else if (20.0 <= m_Avg)
        {
            a_Result += "<Color=#00ff00>";
            a_Result += m_Name + " �л��� D����Դϴ�.";
            a_Result += "</Color>";
        }

        else
        {
            a_Result += "<Color=#00ff00>";
            a_Result += m_Name + " �л��� �ܰ����Դϲ�>.";
            a_Result += "</Color>";
        }

        return a_Result;
  
    }
}

public class StudentGradeMgr : MonoBehaviour
{
    public InputField StName_Ifd;
    public InputField Kor_Ifd;
    public InputField Eng_Ifd;
    public InputField Math_Ifd;

    public Button Ok_Btn;
    public Text Result_Text;

    // Start is called before the first frame update
    void Start()
    {
        if (Ok_Btn != null)
            Ok_Btn.onClick.AddListener(OkBtnClick);
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    private void OkBtnClick()
    {
        //��ǲ�ʵ�κ��� ���� �޾ƿͼ� �� �� ������ �����ؼ� ������ ��Ƶα�...
        string a_StName = StName_Ifd.text.Trim();

        if (string.IsNullOrEmpty(a_StName) == true)
            return;  //�̸� �Է� ���ڿ� ���� ��� ������...

        int a_Kor = 0, a_Eng = 0, a_Math = 0;
        bool a_IsKorOk = int.TryParse(Kor_Ifd.text.Trim(), out a_Kor);
        bool a_IsEngOk = int.TryParse(Eng_Ifd.text.Trim(), out a_Eng);
        bool a_IsMathOk = int.TryParse(Math_Ifd.text.Trim(), out a_Math);

        //����, ����, ���� �Է� ���ڿ� ���� ���ų� �������°� �ƴϸ�...
        if (a_IsEngOk == false || a_IsEngOk == false || a_IsMathOk == false)
            return;

        if ((a_Kor < 0 || 100 < a_Kor) ||
            (a_Eng < 0 || 100 < a_Eng) ||
            (a_Math < 0 || 100 < a_Math))
            return; //����ó��

        Student a_Std = new Student(a_StName, a_Kor, a_Eng, a_Math);
        Result_Text.text = a_Std.PrintInfo();

    }//private void OkBtnClick()
}