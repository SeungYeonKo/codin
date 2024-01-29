using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example09 : MonoBehaviour
{
    string myName = "전민성";  //전역변수 설정 
    float fValue = 3.1415f;
    void Start()
    {
        //1-3 실수형
        float floatValue = 3.14159265358979323846f;   //7자리 정밀도
        double doubleValue = 3.14159265358979323846;  //15자리 정밀도
        decimal decimalValue = 3.14159265358979323846m;  //29자리 정밀도

        Debug.Log(floatValue);
        Debug.Log(doubleValue);
        Debug.Log(decimalValue);

        //2-1,2-2 문자(char),문자열(string) 형
        char charValue1 = '고';
        char charValue2 = '1';
        char charValue3 = '+';
        string stringValue = "고승연";

        Debug.Log(charValue1);
        Debug.Log(charValue2);
        Debug.Log(charValue3);
        Debug.Log(stringValue);


        //문자열을 다루는 방법
        //-> 문자열 서식 string.format ***
        string str0 = "안녕 고승연";

        string str1 = string.Format("{0} {1}", "안녕", myName);  //myName을 넣어줘서 전역변수 전민성 출력
        //첫 번째 변수로 문자열 개수와 서식을 지정
        //두 번째 변수부터 문자열 데이터 전달
        Debug.Log(str0);
        Debug.Log(str1);

        int hour = 1;
        int minute = 15;
        Debug.Log(string.Format("{0}{1}", hour, minute)); //115
        Debug.Log(string.Format("{0} : {1}", hour, minute)); //1 : 15
        Debug.Log(string.Format("현재 시간 - {0} : {1}", hour, minute)); //현재시간 - 1 : 15

        //정렬
        Debug.Log(string.Format("{0, -5} : {1}", hour, minute)); //왼쪽 정렬
        Debug.Log(string.Format("{0,  5} : {1}", hour, minute)); //오른쪽 정렬

        //정수 서식
        Debug.Log(string.Format("{0:D5} : {1}", hour, minute)); //00001:15

        //소수점 서식
        Debug.Log(string.Format("소수점 1자리만 표현 : {0:F1}", fValue));

        //2-2. 문자열 보간
        //$"텍스트(변수, 서식)텍스트"
        Debug.Log($"소수점 1자리만 표현 : {fValue:F1}");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
c#에서 기본으로 제공하는 데이터 타입은 16가지
 1. 숫자형
    1-1. 정수형 : sbyte , short, int, long ( 각각 저장할 수 있는 데이터의 크기, 범위가 다름)
    1-2. 부호 없는 정수형(+,-존재하지않음. 무조건 양수) : byte, ushort, uint, ulong
            *int와 uint의 차이  
            * int는 정수형 숫자를 저장하는 공간. uint는 부호가 없기때문에 -(마이너스)저장하지 못하지만 보통의 int 보다 양수를 두배 더 저장할 수 있음
    1-3. 실수형 : float, double, decimal(소수점이 있는 숫자)
            *float : 7자리 정밀도
            *double : 15자리 정밀도
            *decimal : 29자리 정밀도
 
 2. 문자/문자열 형
    2-1. 문자 : char, 문자열 : string
    2-2. 문자열 보관 :  $"텍스트(변수,서식)텍스트"
     
----------------------------------------------------------------------------------------------------------------------------
 필요한 값의 범위보다 큰 자료형을 쓰면?
 -> 무의미하게 버려지는 데이터 공간이 많아진다 = 메모리 공간 낭비

 필요한 값의 범위보다 작은 자료형을 쓰면?/
 ->오버플로우 or 언더플로우가 발생한다 = 버그 발생
    short number = 40000; -> 오류 발생(40000 상수 값을 short로 변환할 수 없습니다)
    short number = 30000; ->오류가 나지 않음

문자열을 다루는 방법
 -> 문자열 서식 string. format 
            string str0 = "안녕 고승연";
       
                    string str1 = string.Format("{0} {1}", "안녕",myName);  //myName을 넣어줘서 전역변수 전민성 출력
                    //첫 번째 변수로 문자열 개수와 서식을 지정
                    //두 번째 변수부터 문자열 데이터 전달
                    Debug.Log(str0);
                    Debug.Log(str1);

                    int hour = 1;
                    int minute = 15;
                    Debug.Log(string.Format("{0}{1}", hour, minute)); //115
                    Debug.Log(string.Format("{0} : {1}", hour, minute)); //1 : 15
                    Debug.Log(string.Format("현재 시간 - {0} : {1}", hour, minute)); //현재시간 - 1 : 15
-> 정렬
        Debug.Log(string.Format("{0, -5} : {1}", hour, minute));  ->왼쪽 정렬
        Debug.Log(string.Format("{0,  5} : {1}", hour, minute));  ->오른쪽 정렬

-> 정수 서식
        Debug.Log(string.Format("{0:D5} : {1}", hour, minute)); //00001:15

 -> 소수점 서식
        Debug.Log(string.Format("소수점 1자리만 표현 : {0:F1}", 3.124532));

-> 문자형 변환
        
*/