using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;
    void Start()
    {
       /* int A = 90;
        int B = 10;
        int C = 0;*/

        C = A;
        A = B;
        B = C;
        /*A = B;
        B = C;
        C = A;*/

        Debug.Log(A);
        Debug.Log(B);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*

 */
