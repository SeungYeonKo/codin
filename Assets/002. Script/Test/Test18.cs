using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test18 : MonoBehaviour
{
    //구구단 2단 부터 9단
    int i;
    int j;

    void Start()
    {

        int sum = 0;
        for (int i = 2; i <= 9; i++)
        {
           for (int j = 1; j <= 9; j++) 
            {
                sum *= i;
                Debug.Log($"{i}x{j}={i * j}");
            }
        }
    }

    void Update()
    {
        
    }
}
