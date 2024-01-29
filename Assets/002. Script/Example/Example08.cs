using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example08 : MonoBehaviour
{
    void Start()
    {
        //숫자형 - 1-1정수형(sbyte , short, int, long)
        sbyte byteValue = 3;
        short shortValue = 3;
        int intValue = 3;
        long longValue = 3;

        //각 자료형의 최소크기.최대크기
        Debug.Log(sbyte.MinValue);  //0
        Debug.Log(sbyte.MaxValue);  //255

        Debug.Log(short.MinValue);  //-32768
        Debug.Log(short.MaxValue);  //32767

        Debug.Log(int.MinValue);  //-2147483648
        Debug.Log(int.MaxValue);  //2147483647

        Debug.Log(long.MinValue);  //-9223372036854775808
        Debug.Log(long.MaxValue);  //9223372036854775807

        Debug.Log(byteValue);
        Debug.Log(shortValue);
        Debug.Log(intValue);
        Debug.Log(longValue);

       
        //오버플로우 발생
        int number = int.MaxValue;
        number = number + 1;

        Debug.Log(number);

        //언더플로우 발생
        number =  int.MinValue;
        number = number - 1;

        Debug.Log(number);


        //숫자형 - 1-2 부호없는 정수형(byte, ushort, uint, ulong) = 무조건 양수
        byte bValue = 3;
        ushort ushortValue = 3;
        uint uintValue = 3;
        ulong ulongValue = 3;

        Debug.Log (bValue);
        Debug.Log(ushortValue);
        Debug.Log(uintValue);
        Debug.Log(ulongValue);
           
    }

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

  


 //필요한 값의 범위보다 큰 자료형을 쓰면?
        //-> 무의미하게 버려지는 데이터 공간이 많아진다 = 메모리 공간 낭비

 //필요한 값의 범위보다 작은 자료형을 쓰면?/
        //->오버플로우 or 언더플로우가 발생한다 = 버그 발생
        //short number = 40000; -> 오류 발생(40000 상수 값을 short로 변환할 수 없습니다)
        //short number = 30000; ->오류가 나지 않음
 
 
 */
