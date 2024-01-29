using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example31 : MonoBehaviour
{// 2차원 배열의 초기화


    void Start()
    {
        int[] arr = new int[] {1, 2, 3};

        //2차원배열 초기화
        int[,] arr2 = new int[,]
        {
            {31, 28, 45 },
            {10, 56, 68 }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
