using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example06 : MonoBehaviour
{
    const int AGE = 23; //const : 상수 선언

    void Start()
    {
       // AGE = 230;  에러가 남    
       // 에러의 이유 : age 선언할 때 상수로 변수를 선언했기 때문. 상수는 변하지 않는 값
    }

    void Update()
    {
        
    }
}


/*
 -const : 변하지 않는 값인 상수를 의미
 -변수를 선언할 때만 값을 초기화할 수 있고, 이후 값을 변경하고 싶지 않을 때 사용
 -보통 상수를 선언할때 변수값을 대문자로 선언함

 */