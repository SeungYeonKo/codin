using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test15 : MonoBehaviour
{
    public int n;

    void Start()
    {
        int sum = 0;
        for (int i = 1; i < n + 1; i++)
        {
            if (i % 3 != 0)
            {
                sum += i;
            }
        }
        Debug.Log(sum);
    }
 }

