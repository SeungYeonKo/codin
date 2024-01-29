using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class Test39 : MonoBehaviour
{// 39.최댓값(2차원배열)



    void Start()
    {
        int maxNumber = 0;                      //최댓값
        string A = "";                                 //최댓값 위치 출력

        int[,] inputArray = new int[9, 9]
        {
            { 3, 23, 85, 34, 17, 74, 25, 52, 65 },
            { 10, 7, 39, 42, 88, 52, 14, 72, 63 },
            { 87, 42, 18, 78, 53, 45, 18, 84, 53 },
            { 34, 28, 64, 85, 12, 16, 75, 36, 55 },
            { 21, 77, 45, 35, 28, 75, 90, 76, 1 },
            { 25, 87, 65, 15, 28, 11, 37, 28, 74 },
            { 65, 27, 75, 41, 7, 89, 78, 64, 39 },
            { 47, 47, 70, 45, 23, 65, 3, 41, 44 },
            { 87, 13, 82, 38, 31, 12, 29, 29, 80 }
        };
 
        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (inputArray[y, x] > maxNumber)
                    {
                        maxNumber = inputArray[y, x];
                        A = $"{y+1}   {x+1}";
                    }
                }
            }
        }
        Debug.Log(maxNumber);  //최댓값 출력
        Debug.Log(A);
    }
}
//Debug.Log(inputArray.Length);                 -> 81개
//  Debug.Log($"{locationX}  {locationY}");    ->위치 출력
//maxNumber의         y값              x값
// inputArray[y,0] = locationY;
//
//
//
//
//inputArray[0, x] = locationX;