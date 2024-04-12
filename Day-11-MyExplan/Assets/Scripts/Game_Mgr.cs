using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum GawiBawiBo
{
    Gawi = 1,
    Bawi = 2,
    Bo = 3
}

public enum Record
{
    Draw = 0,  //비겼다.
    Win  = 1,  //이겼다.
    Lost = 2   //졌다.
}

public class Game_Mgr : MonoBehaviour
{
    public Button Gawi_Btn;     //가위 버튼 연결 변수
    public Button Bawi_Btn;     //바위 버튼 연결 변수
    public Button Bo_Btn;       //보 버튼 연결 변수
    public Button Replay_Btn;   //게임다시하기 버튼 연결 변수

    public Text UserInfo_Text;  //유저 정보 표시 텍스트
    public Text Result_Text;    //결과 표시 텍스트

    int m_Money = 1000;         //유저의 보유 금액
    int m_WinCount = 0;         //승리 카운트
    int m_LostCount = 0;        //패배 카운트

    [Header("--- ShowUserData ---")]
    public InputField NickNameIF;   //별명 입력 상자
    public Button NickInput_Btn;    //별명 입력 버튼
    string m_NickName = "유저";

    [Header("--- Direction Image ---")]
    public Image UserGBB_Img;   //UserSelPanel의 GBB Image
    public Image ComGBB_Img;    //ComSelPanel의 GBB Image

    public Sprite[] m_IconSprite;  //가위, 바위, 보 스프라이트를 연결할 배열 변수

    #region //--- 이전소스
    //public Sprite GawiIcon;     //가위 텍스쳐
    //public Sprite BawiIcon;     //바위 텍스쳐
    //public Sprite BoIcon;       //보 텍스쳐
    #endregion

    float m_WaitTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (Gawi_Btn != null) //여기에 가위 버튼이 잘 연결 되어 있으면....
            Gawi_Btn.onClick.AddListener(()=>
            {
                BtnClickMethod(GawiBawiBo.Gawi);
            });

        if (Bawi_Btn != null)
            Bawi_Btn.onClick.AddListener(()=>
            {
                BtnClickMethod(GawiBawiBo.Bawi);
            });

        if (Bo_Btn != null)
            Bo_Btn.onClick.AddListener(()=>
            {
                BtnClickMethod(GawiBawiBo.Bo);
            });

        if (Replay_Btn != null)
            Replay_Btn.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("SampleScene");
            });

        //--- User Data Loading
        if (NickNameIF != null)
            NickNameIF.text = "유저";
        //--- User Data Loading

        if (NickInput_Btn != null)
            NickInput_Btn.onClick.AddListener(NickNameBtnClick);

    }//void Start()

    // Update is called once per frame
    void Update()
    {
        if(0.0f < m_WaitTimer)
        {
            m_WaitTimer -= Time.deltaTime;
            if(m_WaitTimer <= 0.0f)
            {
                UserGBB_Img.gameObject.SetActive(false);
            }
        }//if(0.0f < m_WaitTimer)

    }//void Update()


    void BtnClickMethod(GawiBawiBo a_UserSel)
    {
        if (m_Money <= 0)
            return;

        GawiBawiBo a_ComSel = (GawiBawiBo)Random.Range((int)GawiBawiBo.Gawi,
                                                       (int)GawiBawiBo.Bo + 1);

        string a_strUser = "가위";
        if (a_UserSel == GawiBawiBo.Bawi)
            a_strUser = "바위";
        else if (a_UserSel == GawiBawiBo.Bo)
            a_strUser = "보";

        string a_strCom = "가위";
        if (a_ComSel == GawiBawiBo.Bawi)
            a_strCom = "바위";
        else if (a_ComSel == GawiBawiBo.Bo)
            a_strCom = "보";

        Result_Text.text = "User(" + a_strUser + ") : Com(" + a_strCom + ")";

        //--- 판정
        Record IsWin = Record.Draw;
        if (a_UserSel == a_ComSel)
        {
            Result_Text.text += " 비겼습니다.";
            IsWin = Record.Draw;
        }
        else if ((a_UserSel == GawiBawiBo.Gawi && a_ComSel == GawiBawiBo.Bo) ||
                 (a_UserSel == GawiBawiBo.Bawi && a_ComSel == GawiBawiBo.Gawi) ||
                 (a_UserSel == GawiBawiBo.Bo && a_ComSel == GawiBawiBo.Bawi))
        {
            Result_Text.text += " 이겼습니다.";
            IsWin = Record.Win;
        }
        else
        {
            Result_Text.text += " 졌습니다.";
            IsWin = Record.Lost;
        }

        #region //--- 이전 소스
        //Record IsWin = Record.Draw;
        //if (a_UserSel == a_ComSel)
        //{
        //    Result_Text.text += " 비겼습니다.";
        //    IsWin = Record.Draw;
        //}
        //else if (a_UserSel == GawiBawiBo.Gawi && a_ComSel == GawiBawiBo.Bo)
        //{
        //    Result_Text.text += " 이겼습니다.";
        //    IsWin = Record.Win;
        //}
        //else if (a_UserSel == GawiBawiBo.Bawi && a_ComSel == GawiBawiBo.Gawi)
        //{
        //    Result_Text.text += " 이겼습니다.";
        //    IsWin = Record.Win;
        //}
        //else if (a_UserSel == GawiBawiBo.Bo && a_ComSel == GawiBawiBo.Bawi)
        //{
        //    Result_Text.text += " 이겼습니다.";
        //    IsWin = Record.Win;
        //}
        //else
        //{
        //    Result_Text.text += " 졌습니다.";
        //    IsWin = Record.Lost;
        //}
        #endregion
        //--- 판정

        //--- 보상
        if (IsWin == Record.Win) //이겼을 때 
        {
            m_WinCount++;
            m_Money += 100;
        }
        else if(IsWin == Record.Lost) //졌을 때 
        {
            m_LostCount++;
            m_Money -= 200;
            if(m_Money <= 0)
            {
                m_Money = 0;
                Result_Text.text = "Gamw Over";
            }
        }
        //--- 보상

        //--- 유저 정보 UI 갱신
        if (UserInfo_Text != null)
            UserInfo_Text.text = m_NickName + "의 보유금액 : " + m_Money +
                                 " : 승(" + m_WinCount + ")" +
                                 " : 패(" + m_LostCount + ")";
        //--- 유저 정보 UI 갱신

        //--- 선택 상태에 따른 이미지 교체 코드
        UserGBB_Img.sprite = m_IconSprite[(int)a_UserSel - 1];
        UserGBB_Img.gameObject.SetActive(true);

        ComGBB_Img.sprite = m_IconSprite[(int)a_ComSel - 1];

        #region //--- 이전 소스
        ////UserGBB_Img.sprite = GawiIcon;
        ////UserGBB_Img.gameObject.SetActive(true);

        ////if (a_ComSel == 1)      //컴퓨터가 가위 선택
        ////    ComGBB_Img.sprite = GawiIcon;
        ////else if (a_ComSel == 2) //컴퓨터가 바위 선택
        ////    ComGBB_Img.sprite = BawiIcon;
        ////else if (a_ComSel == 3) //컴퓨터가 보 선택
        ////    ComGBB_Img.sprite = BoIcon;
        #endregion
        ////--- 선택 상태에 따른 이미지 교체 코드

        m_WaitTimer = 3.0f;  //<-- 타이머 설정
    }
 
    private void NickNameBtnClick()
    {
        if (m_Money <= 0)
            return;

        string a_Nick = NickNameIF.text;
        if (a_Nick == "")
            m_NickName = "유저";
        else
            m_NickName = a_Nick;

        //--- 유저 정보 UI 갱신
        if(UserInfo_Text != null)
            UserInfo_Text.text = m_NickName + "의 보유금액 : " + m_Money + 
                                " : 승(" + m_WinCount + ")" + 
                                " : 패(" + m_LostCount + ")";
        //--- 유저 정보 UI 갱신
    }

}
