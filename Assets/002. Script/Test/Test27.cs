using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test27 : MonoBehaviour
{//27. 최댓값

/*
//방법 1.
    public int[] A;          //자연수를 담을 배열 A

    void Start()
    {
        int max = 0;
        int location = 0;

        for(int i = 0; i<A.Length; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
                location = i;
            }
        }
        Debug.Log(max);     //최댓값 출력
        Debug.Log(location);      //몇번째인지 출력
    }
}
*/

//방법2. 
    public int[] A;          //자연수를 담을 배열 A


    void Start()
    {
        //가장 큰 값을 저장할 변수
        int maxNumber = 0;
        int location = 0;   

        for (int i = 0; i < A.Length; i++)
        {
            //1. 현재 위치에 있는 배열을 가져온다
            int number = A[i];

            //2. 현재 값이 maxNumber보다 크면 교체
            if (number > maxNumber)
            {
                //가장 큰 값 교체
                maxNumber = number;
                //가장 큰 값이 있는 위치도 교체
                 location = i ;
            }
        }
        Debug.Log(maxNumber);
        Debug.Log(location + 1);            //인덱스값은 0부터 시작이기 때문에 +1을 해줌
    }
}



/*if (a[i] > max)   //최댓값
{
    max = a[i];
*/
//

//Debug.Log(A.Length);  //배열A안에 있는 자연수의 갯수출력

//int max = 0;
//int count = A.Length;


/*for (int i = 0; i < A[i]; i++)
{
    for ()
    {
        max = A[i];
    }
    Debug.Log(max);
} //배열 A안에 있는 모든 수를 출력*/