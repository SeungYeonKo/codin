using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test36 : MonoBehaviour
{//36. 숫자의 합

    public string S;

    void Start()
    {
        int sum = 0;
        foreach(char Achar in S)
        {
            int A = int.Parse(Achar.ToString());
            sum += A;
        }
        Debug.Log(sum);
    }
}
