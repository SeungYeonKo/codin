using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test26_1 : MonoBehaviour
{ // 평균_1

    public int[] A;       //평균을 낼 정수들을 저장할 배열 A

    void Start()
    {
        int sum = 0;

        //배열 A에 저장된 모든 값을 더해준다
        for (int i = 0; i < A.Length; i++)
        {
            sum += A[i];
        }
       
       int answer = A.Length;  // 저장된 배열의 갯수를 알아낸다
                           
        //알아낸 갯수로 합한 값을 나눠준다
        float final = (float)sum / answer;   //int형이었던 sum/answer을  float형으로 변환

        Debug.Log(final);
    }
}
