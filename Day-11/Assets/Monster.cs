using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace MyTeam {
    public class monster
    {
        public string m_Name;     //���� �̸�
        public int m_HP;          //ü��
        public int m_MP;           //����
        public int m_Attack;        //���ݷ�




        public void PrinInfo()
        {
            Debug.Log("�̸�" + m_Name + ", ü��(" + m_HP + ") ����(" + m_MP + "), ���ݷ�(" + m_Attack + ")");
        }
    }
}



