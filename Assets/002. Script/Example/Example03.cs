using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example03 : MonoBehaviour
{
    void Start()
    {
        float height = 162.3f;
        int testNumber;

        testNumber = 0;

        Debug.Log("키 : " + height);
        Debug.Log("테스트넘버 : " + testNumber);
    }

    void Update()
    {
        
    }
}


/*
 -변수의 특징
    1. 변수 이름은 대, 소문자를 구분함
    2. 변수 이름은 숫자로 시작할 수 없음
    3. 변수 이름은 의미있게 지어야함
    4. 변수를 활용하기 전에 값을 미리 할당해 두는게 좋음 
            -초기화 : 값을 할당하는 것
            -초기값 : 처음 초기화할 때 저장하는 값
    5.  
 */