using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test20 : MonoBehaviour
{
    public int n;

    void Start()
    {
        for (int i = 1; i <= n; i++)
        {
            string s = " ";
            for (int j = 1; j <= i; j++)
            {
                s += "*";
            }
            Debug.Log(s);
        }
    }

    void Update()
    {
        
    }
}
