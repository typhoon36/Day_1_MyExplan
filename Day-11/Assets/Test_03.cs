//#define KOREA       //�̷������� ������ָ� ���� �����鼭 ��������� ���۽�Ű�� ����
//#define ENGLISH
//#define CHINA

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���Ǻ� ������ (��ó����)
// �پ��� ������ �ϳ��� ������Ʈ�� ���� �ϱ� ������ �����̴�.

//ȸ������ �Ǹ� �ڵ���ü�� ������ �ȵ� Ȱ��ȭ �ؾߵ� ����󿡼� ������.

//��ó���� -- #�� �پ��ִ� �����̸�,���� ������ �����ϴ� ����

public class Test_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if KOREA
     Debug.Log ("�̰��� �ѱ۹����Դϴ�.");
#elif ENGLISH
     Debug.Log ("�̰��� ��������Դϴ�.");
#elif CHINA
     Debug.Log ("�̰��� �߱��� �����Դϴ�."); //�̷� ������ ������ �߱��� ��� ��� ���������༭ �Ҷ� define ���Ѽ� ����ְԵ�
        //���� ������ ���ε��� �ϸ� �ȵǴ� �ϳ��� ������Ʈ�� �ؼ� ���� ���ָ� ��.
#endif

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
#if UNITY_EDITOR
        //Debug.Log("����Ƽ�����Ϳ��� ����");
        GUI.Label(new Rect(55, 10, 500, 60), "<size=25>" + "����Ƽ�����Ϳ��� ����" + "</ size");
#elif UNITY_STANDALONE_WIN
       GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "������ ����������� ����"+"<��size>");


#elif UNiTY_ANDROID
        //Debug.Log("�ȵ���̵忡�� ����");
        GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "�ȵ���̵忡�� ����"+"<��size>");
#elif UNiTY_IOS
       // Debug.Log("�������������� ����");
        GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "���������� ����"+"<��size>");
#elif UNiTY_WEBGL
       //Debug.Log("������ ����");
        GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "������ ����"+"<��size>");
#endif
    }
}
