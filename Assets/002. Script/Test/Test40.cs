using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test40 : MonoBehaviour
{ // 40. 가로 읽기


    string Answer = "";


    void Start()
    {
        char[][] inputArray = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'D', 'E' },
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { '0', '1', '2', '3', '4' },
            new char[] { 'F', 'G', 'H', 'I', 'J' },
            new char[] { 'f', 'g', 'h', 'i', 'j' }

        };

        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                Answer =$"({ inputArray[y]}+ {inputArray[x]})";
                
            }
        }
    }
}
//Debug.Log(inputArray[y][x]);



/*    for (int y = 0; y < 5; y++)
       {
           for (int x = 0; x < 5; x++)
           {
               Debug.Log(inputArray[y, x]);
           }
       }
*/

