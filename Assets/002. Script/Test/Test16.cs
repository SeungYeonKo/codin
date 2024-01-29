using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test16 : MonoBehaviour
{
    public int n;

    void Start()
    {
        int sum = 1;     //n*0=0
        for(int i =1; i<= n; i++)
        {
            sum *= i;
        }
        Debug.Log(sum);
    }

    void Update()
    {
        
    }
}
