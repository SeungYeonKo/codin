using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    void Start()
    {
        Debug.Log((A + B) % C);
        Debug.Log(((A % C) + (B % C)) % C);
        Debug.Log((A * B) % C);
        Debug.Log(((A % C) * (B % C)) % C);


    }

    void Update()
    {
        
    }
}


//  Debug.Log($"{a}+{b}={a + b}");

// bool result1 = (num1 == num2);  //equal연산자(같은지 판단)
// Debug.Log(result1);