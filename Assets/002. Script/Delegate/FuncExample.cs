using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FuncExample : MonoBehaviour
{
    void Start()
    {
        // Func<T1, T2, ... , TResult>
        // 입력 : T타입
        // 반환 : TResult
        // 반드시 반환값이 있고, 매개 변수를 0~16개인 메서드를 담을 수 있는 대리자
        Func<int, bool> a = IsOdd;
        Debug.Log(a(17));

        // 람다표현식을 이용한 방식
        Func<int, bool> b = (num) => num % 2 ==  1;
    }

    // 홀수 판별 함수
    bool IsOdd(int num)
    {
        return num % 2 == 1;
    }
}
