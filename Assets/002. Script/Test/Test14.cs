using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test14 : MonoBehaviour
{//1부터 n까지 합

    public int n;               //합할 정수들을 입력해 준다

    void Start()
    { 
        int  sum=0;

        for (int i = 1; i <= n; i++)        //1부터  n까지 
        {
            sum += i;       //더해줌
        }
        Debug.Log(sum);         //더한 값 출력
    }
}
  