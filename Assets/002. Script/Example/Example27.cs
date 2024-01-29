using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example27 : MonoBehaviour
{
    void Start()
    {
        //문자
        //char a = 't';

        //문자열 = 문자 + 배열
    
        string b = "Hello";
        Debug.Log(b[0]);
        Debug.Log(b[1]);
        Debug.Log(b[2]);
        Debug.Log(b[3]);

        Debug.Log(b.Length);   //문자열도 배열처럼 길이를 알 수 있는  Length 속성이 있다

        //b[0] = 'k'; -> 각 요소에 접근해서 값을 확인할 수는 있지만 값을 수정해 줄 수는 없음 = 불변의 성질

        string c = "Hello";
        c = c + "K";  //문자열을 묶는 것은 사실 내부적으로 새로 만드는 것이다.

        Debug.Log(c);
    }

    void Update()
    {
        
    }
}
