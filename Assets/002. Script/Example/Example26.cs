using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example26 : MonoBehaviour
{//

    void Start()
    {
        string firstName = "전";
        string lastName = "민성";
        string displayName = string.Empty;   // 이름 : 전민성
        //string.Empty = "" 큰따옴표 두개와 같은 기능

        //1. 더하기 (+) 연산자 사용
        displayName = "이름 : " + firstName +  lastName;    //문자에서 " + " 는 붙여주는 기능
        Debug.Log(displayName);

        //2. string.Format 사용
        displayName = string.Format("이름 : {0}{1}}", firstName, lastName);
        Debug.Log(displayName);

        //3. 문자열 보간법 ($) 사용
        displayName = $"이름 : {firstName}{lastName}";
        Debug.Log(displayName);

    }

    void Update()
    {
        
    }
}
