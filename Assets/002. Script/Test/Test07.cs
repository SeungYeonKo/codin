using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Test07 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    //오름차순 비교

    void Start()
    {
        if (A < B)
        {
            if (B < C)
            {
                Debug.Log($"{A}{C}{B}");
            }
            else if (C < A)
            {
                Debug.Log($"{C}{A}{B}");
            }
            else
            {
                Debug.Log($"{A}{B}{C}");
            }
        }
        else
        {
            if (C < B)
            {
                Debug.Log($"{C}{B}{A}");
            }
            else if (C > A)
            {
                Debug.Log($"{B}{A}{C}");
            }
            else
            {
                Debug.Log($"{B}{C}{A}");
            }
        }




        /* Debug.Log(A);
         Debug.Log(B);
         Debug.Log(C);*/


       

    }
}
