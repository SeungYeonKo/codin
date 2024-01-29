using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example22 : MonoBehaviour
{
    // 점프문 : continue

    /* void Start()
     {
         //숫자 1부터 10까지 출력하는 for 반복문:
         for (int i = 1; i <= 10; i++)
         {
             if (i == 5)  //i가 5가되면
             {
                 continue;   //반복문에서 아래 코드들의 실행을 건너뛸 때 사용
             }
             Debug.Log(i);
         }
         Debug.Log("반복문종료");
     }*/
    void Start()
    {
        //숫자 1부터 10까지 출력하는 for 반복문:
        for (int i = 1; i <= 100; i++)
        {
            if (i%2 != 0)    //홀수면
            {
                continue;       //건너뛰어버려
            }
            Debug.Log(i);       //그리고 출력
        }
    }

    void Update()
    {
        
    }
}
