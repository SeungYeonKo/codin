using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example14 : MonoBehaviour
{
    void Start()
    {
        int num1 = 40;
        int num2 = 30;
        int num3 = 20;

        //&&(AND)
        bool result1 = num1 > num2  &&  num2 > num3;      //   true   &&   true   ->   true

        //||(OR)
        bool result2 = num1 > num2 || num2 < num3;           //   true   ||   false    ->    true

        //!(NOT)
        bool result3 = !true;                                                     //   ->   false

        Debug.Log(result1);
        Debug.Log(result2);
        Debug.Log(result3);


        //&&(AND) 예시
        //00분식점은 오픈 시간이 10시부터 20시 까지 입니다
        int hour = 12;
        bool isOpen = 10 <= hour && hour <= 20;

        //||(OR) 예시
        //00분식점은 할인 시간이 15시 또는 19시 입니다.
        bool isDiscountTime = (hour == 15) ||( hour == 19); 

        Debug.Log(isOpen);
        Debug.Log(isDiscountTime);
    }
}

/*
 논리연산자
    조건을 비교하는 비교 연산자가 동시에 두 개 이상일 때 사용한다
    결과는 true, false
    
    1. &&(AND) : 두 조건이 모두 참일 때만 참(그리고)
    2. ||   (OR) : 두 조건 중 하나만 참이어도 참(또는)
    3. !    (NOT) : 참은 거짓으로, 거짓은 참으로 바꿔주는 연산자
 */