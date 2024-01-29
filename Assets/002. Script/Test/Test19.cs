using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test19 : MonoBehaviour
{
    public int n;
    /* void Start()
     {
         for (int i = 1; i <= n; i++)
         {
             string s = " ";
             for (int j = 1; j <= i; j++)
             {
                 s += "*";    //s=s+*           
             }
             Debug.Log(s);
         }
     }*/


    void Start()
    {
        for (int i = 1; i <= n; i++)
        {
            string star = "";
            for (int j = 1; j <= i; j++)
            {
                star += "*";    //s=s+*           
            }
            Debug.Log(star);
        }


    }
}

/*
public int n;
void Start()
{
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
        Debug.Log("*");
    }*/

/*for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
      
}*/



/*


string s = " ";
s += "*";

Debug.Log(s);

 */


/*
 
 
 
 
 
 
 
 
 
 
 
 
 */