//#define KOREA       //이런식으로 명명해주면 불이 들어오면서 빌드시점에 동작시키게 해줌
//#define ENGLISH
//#define CHINA

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//조건부 컴파일 (전처리문)
// 다양한 버전을 하나의 프로젝트로 고나리 하기 유용한 문법이다.

//회색으로 되면 코드자체가 포함이 안됨 활성화 해야됨 빌드상에서 지워짐.

//전처리문 -- #이 붙어있는 명렁어이며,빌드 시점에 동작하는 명렁어

public class Test_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if KOREA
     Debug.Log ("이것은 한글버젼입니다.");
#elif ENGLISH
     Debug.Log ("이것은 영어버젼입니다.");
#elif CHINA
     Debug.Log ("이것은 중국어 버젼입니다."); //이런 식으로 영어대사 중국어 대사 등등 번역시켜줘서 할때 define 시켜서 띄워주게됨
        //만약 버전을 따로따로 하면 안되니 하나의 프로젝트를 해서 관리 해주면 됨.
#endif

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
#if UNITY_EDITOR
        //Debug.Log("유니티에디터에서 실행");
        GUI.Label(new Rect(55, 10, 500, 60), "<size=25>" + "유니티에디터에서 실행" + "</ size");
#elif UNITY_STANDALONE_WIN
       GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "윈도우 실행버전에서 실행"+"<／size>");


#elif UNiTY_ANDROID
        //Debug.Log("안드로이드에서 실행");
        GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "안드로이드에서 실행"+"<／size>");
#elif UNiTY_IOS
       // Debug.Log("아이폰에서에서 실행");
        GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "아이폰에서 실행"+"<／size>");
#elif UNiTY_WEBGL
       //Debug.Log("웹에서 실행");
        GUI.Label(new Rect(55, 10, 500, 60),"<size=25>" + "웹에서 실행"+"<／size>");
#endif
    }
}
