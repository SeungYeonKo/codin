using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 네임스페이스
// using으로 시작하는 문장 : 이 스크립트 파일에서 필요한 외부 기능을 가져다 쓰겠다는 의미


//하나의 스크립트 파일은 하나의 '클래스'와 대응된다 
public class Example01 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello C#~");
    }

    void Update()
    {
      //Debug.Log("업데이트");

    }
}

/*
 -MonoBehaviour : 클래스 파일을 컴포넌트로 만들어준다. = '스크립트 대본을 게임 오브젝트에 부착한다는 말(unity엔진의 기능이기 때문에 3번째 줄의 using UnityEngine 을 지우면 실행이 되지 않음)
 -Start/Update는 함수
 -함수란 유니티에서 일정 시점에 실행되는 코드
 -void Start() : 게임이 시작할 때 한번 실행됨
 -void Update() : 게임이 시작하고 나서 매 프레임마다 실행됨
 */