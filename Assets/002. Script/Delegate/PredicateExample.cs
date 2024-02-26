using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PredicateExample : MonoBehaviour
{
    void Start()
    {
        // Predicate<T1, T2, ... , TResult>
        // 입력 : T타입
        // 반환 : bool 타입
        // 반드시 반환값이 bool 형식, 매개 변수를 0~16개인 메서드를 담을 수 있는 대리자
        Predicate<int> a = IsOdd;
        Debug.Log(a(18));
    }

    // 홀수 판별 함수
    bool IsOdd(int num)
    {
        return num % 2 == 1;
    }
}
