using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test29 : MonoBehaviour
{//29. 배열 뒤집기

    public int[] A = new int[] { 3, 29, 38, 12, 57, 74, 40, 85, 61 };

    void Start()
    {//A에 담긴 원소의 순서를 역순으로 바꾸는 프로그램

//int aLength = A.Length;  //배열 A의 길이 
        int[] B = new int[A.Length];  //배열 A와 길이가 같은 배열 B 생성

        //1. 배열 A의 각 요소의 값을 B로 복사
        for(int i = 0; i <A.Length; i++)
        {
            B[i] = A[i];
        }

        //2. 배열 B의 각 요소의 값을 거꾸로 A 로 복사
        //B[5] -> A[0]
        //B[4] -> A[1]
        //...
        //B[0] -> A[5]       <--A[A.Length - i - 1] = B[i]
        for(int i = 0; i < A.Length ; i++)
        {
            A[A.Length - i - 1] = B[i];
        }
        //2. 배열 A의 각 요소 값을 출력한다
        foreach(int num in A)
        {
            Debug.Log(num);
        }

        


            


           /*box[8] = A[0];
           box[7] = A[1];
           box[6] = A[2];
           box[5] = A[3];
           box[4] = A[4];
           box[3] = A[5];
           box[2] = A[6];
           box[1] = A[7];*/
            // box[1] = A[7];



            
    }
}

//배열을 하나 더 만들어라
//몸은 쉬더라도 머리는 쉬지마라`~~~~~~~

/*box[0] = A[0];
A[0] = A[8];
A[8] = box[0];

box[1] = A[1];
A[1] = A[7];
A[7] = box[1];

box[2] = A[2];
A[2] = A[6];
A[6] = box[2];

box[3] = A[3];
A[3] = A[5];
A[5] = box[3];*/