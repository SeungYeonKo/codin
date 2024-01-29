using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test37 : MonoBehaviour
{//37. 반대로 출력하기

    public string InputString = "Hello C#~";

    void Start()
    {
        string result  = string.Empty;
        for (int i = InputString.Length -1; i>=0; i--)
        {
            result += InputString[i];
        }
        Debug.Log(result);
    }
}

/* 다른  방법
 public string S;                 //입력으로 사용될 문자열 S

  void Start()
 {
     char[] charArr = S.ToArray();       // 문자열 S를 문자 배열 charArr로 변환
     Array.Reverse(charArr);     // 문자 배열을 뒤집음
     string newStr = new string(charArr);    // 뒤집힌 문자 배열을 다시 문자열로 변환
     Debug.Log(newStr);      // 뒤집힌 문자열을 콘솔에 출력
 }
}
ToArray() 메서드는 : 문자열을 문자 배열(char[])로 변환하는 역할을 한다*/