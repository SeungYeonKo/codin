using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test17 : MonoBehaviour
{//구구단

    public int n;

    void Start()
    {
        int sum = 1;
        for (int i = 1; i <= 9; i++)
        {
            sum *= n;
            Debug.Log($"{n}x{i}={n*i}");
        }
    }
    




    void Update()
    {

    }
}
