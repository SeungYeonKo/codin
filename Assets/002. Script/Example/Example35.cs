using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35 : MonoBehaviour
{
    /**
       // 반환 자료형이 없을 경우: void
      '반환 자료형' '함수 이름'('매개변수 목록')
       {
            // 실행할 코드들
            // return 반환 데이터
       }
    **/

    // 함수 오버로드: 같은 이름의 함수를 중복해서 만드는 것
    // - 매개 변수 개수를 다르게 할 수 있고,
    // - 매개 변수 타입도 다르게 할 수 있고
    // C# 해석기가 똑똑하게 판단해서 함수를 호출한다.

    // 호출: 함수이름([매개변수]);


    int Sum(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }


    int Sum(float n1, float n2)
    {
        return (int)(n1  +n2);
    }

    int Sum(int number1, int number2, int number3)
    {
        int result = number1 + number2+number3;
        return result;
    }

    void Start()
    {
        // 더하기
        int num1 = 0;
        int num2 = 0;
        int result = 0;

        num1 = 1;
        num2 = 3;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");

        num1 = 17;
        num2 = 9;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");

        num1 = 22;
        num2 = 33;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");


        Debug.Log(Sum(1, 2));
        Debug.Log(Sum(1, 2, 3));
        Debug.Log(Sum(1f, 2f));
    }

    void Update()
    {
        
    }
}
