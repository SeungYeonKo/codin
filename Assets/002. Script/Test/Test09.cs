using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test09 : MonoBehaviour
{
    public int year;

    void Start()
    {
        if (year != year * 100 && year % 4 == 0)
        {
            Debug.Log("1");
        }else
        {
            Debug.Log("0");
        }
    }

    void Update()
    {
        
    }
}

//1. 운년은 연도가 4의 배수  
//2. 운년은 연도가 100의 배수가 아닐때  + 4의 배수일 때  (&&)