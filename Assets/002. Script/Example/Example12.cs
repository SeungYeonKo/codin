using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Example12 : MonoBehaviour
{
    void Start()
    {
        //사칙연산자
        int a = 6;
        int b = 2;

        Debug.Log( a + b);
        Debug.Log( a - b);

        //문자열 서식 사용
        Debug.Log($"{a}+{b}={a + b}");
        Debug.Log($"{a}-{b} = {a - b}");
        Debug.Log($"{a}*{b}={a * b}");
        Debug.Log($"{a}/{b}={a / b}");
        Debug.Log($"{a}%{b}={a % b}");

        //대입연산자
        int c = 6; //오른쪽 6을 왼쪽 c에 넣어준다

        //00대입연산자
        /*c = c + 5;
        c += 5;

        c = c - 3;
        c-= 3;

        c = c * 3;
        c *= 3;

        c = c / 7;
        c /= 7;

        c = c % 5;
        c %= 7;
        */

        /* 
        출력방법 다시 복습
         Debug.Log($"c+=5 : {c}");

         Debug.Log($"c-=3 : {c}");

         Debug.Log($"c*=5 : {c}");

         Debug.Log($"c/=5 : {c}");

         Debug.Log($"c%=5 : {c}");
        */

        //1을 더할 때
        c = c + 1;   //덧셈 연산자
        c += 1;      //덧셈 대입 연산자
        c++;          //1 증가 연산자
        c--;            //1 감소 연산자

        ++c;        //c++; 와 최종적으로 결과는 같음

        int number = 10;
        Debug.Log( number );           //10

        Debug.Log( number ++);      //10  //후위 증가 : 다른 연산을 먼저 수행 후, 값 1 증가
        Debug.Log( number );           //11

        Debug.Log(++number );       //12  //전위 증가 : 값 1 증가 후 다른 연산 수행
        Debug.Log(number);             //12
    }
}

/*
 
연산 : 계산을 통해 새로운 값을 만드는 것
"연산자" : 연산을 수행할 때 쓰는 기호

    1. 사칙 연산자 : +, -, /(몫), *, %(나머지)
    2. 대입 연산자 : (계산한)값을 변수에 대입(할당)하는 연산자
        =
    3. 증감 연산자(증가/감소)
        c++ , ++c
        c-- ,--c

*/