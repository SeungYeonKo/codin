using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example02 : MonoBehaviour
{
    void Start()
    {
        int age = 23;
        float height = 162.3f;
        string name = "고승연";
        string mbti = "ENFP";    
        bool isMan = false;

        Debug.Log("나이" + age);
        Debug.Log("키" + height);
        Debug.Log("이름" + name);
        Debug.Log("mbti" + mbti);
        Debug.Log("남자냐?" + isMan);
    }

    void Update()
    {
        
    }
}
/*
 -변수 : 게임 내에서 필요한 데이터(이름,나이) 등을 저장하고 사용하기 위해 배정받은 공간 / 게임 내의 모든 데이터를 저장할 수 있음
 -선언 : 변수를 만드는 것
 -선언에 필요한 것
    1. 데이터를 활용하는 범위
    2. 데이터 타입 ***
    3. 데이터를 부르는 이름(확보한 공간을 지칭하는 이름) = 변수명 *** 
 
 -데이터타입
    1.int(정수)
    2.float(실수)
    3.string(문자열)
    4.char(문자)
    5.boolean(bool = 논리값) : true, false
 */