using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example29 : MonoBehaviour
{//
 
    void Start()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7};

        //arr배열에 있는 모든 값을 for 반복문을 이용해서 출력하고 싶다면
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }

        //foreach반복문 : for반복문처럼 배열안에 있는 모든 값들을 출력할 때 씀
/*
        foreach(자료형 변수명 in 배열)
            {
                변수를 사용하는 코드
            }
*/
        foreach(int num in arr)   //변수명은 의미가 있는  num으로
        {
            Debug.Log(num);
        }
    }
    //단점 1. 코드를 수정할 수가 없다
    //단점 2. 순서를 알 수가 없다
    
    //장점. 코드 길이가 줄어든다

    void Update()
    {
        
    }
}
