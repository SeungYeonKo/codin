using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleTest : MonoBehaviour
{
    void Start()
    {
        People people = new People("이성민", 25, 180.1f, "INFP");
        people.SetAge(26);
        people.SetAge(-3);
        //people.Age = -3; //무결성이 깨졌다
        //무결성 : 데이터의 정확성, 일관성, 유효성


        people.Height = -10;                  // 프로퍼티 set 접근자 사용
        Debug.Log(people.Height);        // 프로퍼티 get 접근자 사용
        
        people.MBTI = "AAA";
       Debug.Log(people.MBTI);

        Debug.Log(people.GetName());
        Debug.Log(people.GetAge());
    }

    // 속성(멤버변수) 은닉화/캡슐화의 문제점 : 
    // 속성을 많이 선언할수록 Get/Set과 같은 메소드가 많아지고, 코드량이 많아져서 관리하기 힘들어 진다
    // 변수에 접근한다는 느낌이 아닌 메소드를 사용한다는 느낌이 커진다

    // 해결 방법 : 프로퍼티
    // 프로퍼티 : 속성이라는 뜻으로 변수의 값을 외부에서 접근할 수 있도록 하면서
    // 동시에 캡슐화를 지원하는 C#의 기능이다
    // -Get 접근자 : 멤버 변수로부터 값을 읽어온다
    // -Set 접근자 : 멤버 변수에 값을 할당한다
}
