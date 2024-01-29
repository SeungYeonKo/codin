using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test25 : MonoBehaviour
{ // 25. 최소, 최대

    public int[] a;      //정수를 담을 배열 a

    void Start()
    {
        int min = 0;
        int max = 0;

        for (int i = 0; i < a.Length; i++)  //a배열 전체를 순회함
        {
            if (a[i] < min)
            {
                min = a[i];
            }
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        Debug.Log($"{min} {max}");      //출력해준다~~~~~~~~~~~~
    }
}
//20 10 35 30 7




/*
 
 정수를 담을 배열 a

 배열 a 에 들어간 정수들끼리 비교
    -배열 안을 다 순회해야함
    -

 최소값, 최대값 출력
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */