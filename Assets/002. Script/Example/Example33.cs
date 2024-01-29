using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Example33 : MonoBehaviour
{//정수형 가변 배열 초기화 방식

    void Start()
    {

        int[][] numbers = new int[3][]
        {
            new int[] {1, 2, 3},
            new int[] {10, 20, 30, 40},
            new int[] {100, 200, 300, 400, 500},
        };

        //Q. 위 가변 배열의 모든 아이템을 출력해보세요.
        // 1. 
        Debug.Log(numbers.Length);           //3 -> 가변 배열의 2차원(세로) 크기를 출력 
        Debug.Log("----------------------------------------------");
        Debug.Log(numbers[0].Length);           //3
        Debug.Log(numbers[1].Length);           //4
        Debug.Log(numbers[2].Length);          //5
        Debug.Log("----------------------------------------------");
        for (int i = 0; i < numbers.Length; i++)        //배열 안의 모든 원소 출력
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Debug.Log(numbers[i][j]);
            }
        }
    }
}