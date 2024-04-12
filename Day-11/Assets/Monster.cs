using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace MyTeam {
    public class monster
    {
        public string m_Name;     //몬스터 이름
        public int m_HP;          //체력
        public int m_MP;           //마나
        public int m_Attack;        //공격력




        public void PrinInfo()
        {
            Debug.Log("이름" + m_Name + ", 체력(" + m_HP + ") 마나(" + m_MP + "), 공격력(" + m_Attack + ")");
        }
    }
}



