using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example05 : MonoBehaviour
{
        int age = 20;

    void Start()
    {
        age = 23;
        age = 218;
        age = 19999;

        Debug.Log(age);
    }

    void Update()
    {
        
    }
}


/*
 지역변수가 이미 존재하더라도 멤버 변수가 선언이 된다면,
 위에서부터 아래로 코드를 읽기때문에 제일 밑에 넣은 변수값을 출력
 */
