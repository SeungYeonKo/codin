using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example21 : MonoBehaviour
{//점프문 : break

    void Start()
    {
        //숫자 1부터 10까지 출력하는 for 반복문:
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)  //i가 5가되면
            {
                break;   //반복문을 종료한다
            }
            Debug.Log(i);
        }
        Debug.Log("반복문종료");
    
    }

    void Update()
    {
        
    }
}

//break : 현재 실행중인 반복문이나  switch문의 실행을 중단할 때 사용한다(종료, 탈출이라고 표현)



/*
숫자 1부터 10까지 출력하는 for 반복문:
for (int i = 1; i <= 10; i++)
{
    Debug.Log(i);
}
*/