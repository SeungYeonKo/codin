using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example23 : MonoBehaviour
{ // 배열

    /* void Start()
     {
         *//*string studentName1 = "김예은";
         string studentName2 = "이성민";
         string studentName3 = "전민성";*//*
         만약 학생이 1000명이라면?
         선언 방식   자료형[] 배열명 = new 자료형[크기]

         int size = 3;
         string[] studentNames = new string[size];

         인덱스 : 각 요소(아이템)의 위치를 나타내는 번호(0번부터 시작)
         studentNames[0] = "김예은";
         studentNames[1] = "이성민";
         studentNames[2] = "전민성";

         for(int i = 0; i <= 2; i++)
         {
          Debug.Log(studentNames[i]);
         }
         *Debug.Log(studentNames[0]);
         Debug.Log(studentNames[2]);
         Debug.Log(studentNames[1]);
     */



    /* void Start()
     {
         int size = 10;
         string[] cafeMenu = new string[size];

         cafeMenu[0] = "아메리카노";
         cafeMenu[1] = "카페라떼";
         cafeMenu[2] = "말차프라푸치노";
         cafeMenu[3] = "캬라멜마끼아또";

         *//*Debug.Log(cafeMenu[0]);
         Debug.Log(cafeMenu[3]);*//*







     }
 }*/
    void Start()
    {
        string[] studentNames = new string[3] { "고승연", "고정인","고수연" };
        /*Debug.Log(studentNames[0]);
        Debug.Log(studentNames[1]);
        Debug.Log(studentNames[2]);*/

        for (int i = 0; i < studentNames.Length; i++)
        {
            Debug.Log(studentNames[i]);
        }

    }

    
}

