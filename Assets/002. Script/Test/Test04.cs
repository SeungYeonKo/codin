using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public int A;
    public int B;

    void Start()
    {
        //3.
        // A * (B의 1의자리) 5
        int num3 = A * (B % 10);
        Debug.Log(num3);
        
        //4.
        // A * (B의 10의자리) 80
        int num4 = A * (B /10 % 10);
        Debug.Log(num4);

        //5.
        // A * (B의 100의자리) 300
        int num5 = A * (B / 100);
        Debug.Log(num5);

        //6.
        Debug.Log(A * B);

    }
}




/*
 패턴 찾기가 중요**
*/



