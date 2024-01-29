using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Test10 : MonoBehaviour
{
    public int X;
    public int Y;

    void Start()
    {
        if (X > 0)
        {
           if(Y > 0)
            {
                Debug.Log("1");
            }else if(Y < 0)
            {
                Debug.Log("4");
            }
        }
        else
        {
            if (Y < 0)
            {
                Debug.Log("3");
            }else if(Y > 0)
            {
                Debug.Log("2");
            }
        }
    }

    void Update()
    {
        
    }
}
