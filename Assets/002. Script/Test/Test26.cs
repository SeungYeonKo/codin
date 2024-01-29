using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

public class Test26 : MonoBehaviour
{//26. 평균

    public int[] A;     //정수를 담을 배열 A 선언

    void Start()
    {
        int sum = A.Sum();      //배열 A에 저장된 모든 값을 더해준다
        //Debug.Log(sum);

        //저장된 배열의 갯수를 알아낸다
        //알아낸 갯수로 합한 값을 나눠준다
        int answer = A.Length;  // 저장된 배열의 갯수
        //Debug.Log(answer);

        int final = sum / answer;

        Debug.Log((float)final);

        //displayName = string.Format("이름 : {0}{1}}", firstName, lastName);
       // Debug.Log(displayName);

        //결과를 float으로 변환해 출력해준다

        //20 10 35 30 7


    }
}



//20.4

/*int answer = 0;

       for (int i = 0; i < A.Length; i++)
       {


       }
       Debug.Log(answer);*/

/*  for (int i = 0; i < A.Length; i++) 
      {
          Debug.Log(A[i]);        
      }*/