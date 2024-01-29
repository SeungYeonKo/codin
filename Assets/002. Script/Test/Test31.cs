using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test31 : MonoBehaviour
{//31. 문자와 문자열

    public string S;
    public int i;

    void Start()
    {
        char a = S[i-1];                              //char a = 문자 a  -> 배열은 0부터 시작 -1 해줘야 3번째자리 r .  [3]은 4번째 o를 가리킴
        Debug.Log(char.ToUpper(a));       //문자 a를 대문자로 출력
    }
}