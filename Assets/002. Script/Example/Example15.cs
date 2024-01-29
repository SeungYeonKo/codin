using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example15 : MonoBehaviour
{
    void Start()
    {
        int a = 10;
        int b = 20;

        //괄호 연산자
        bool example = ((a++) * 5) + 2 > (++b + 1 * 3 / 2) ;

        Debug.Log(example);
    }
}

/*
 
연산자 우선순위 https://thebook.io/006890/0191/

 괄호 연산자 -> 증감 연산자 -> 산술 연산자 -> 연결 연산자 -> 관계 연산자 -> 논리 연산자

 */