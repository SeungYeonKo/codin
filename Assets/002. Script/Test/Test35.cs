using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test35 : MonoBehaviour
{
    // 35.문자열 (첫글자와 마지막 글자를 출력)

    /* public string S;

     void Start()
     {
         for (int i = 0; i < S.Length; i++)
         {
             if (S[i] == S[0])  //if문이 있어야 한번만 출력
             {
                 Debug.Log(S[0]);   //첫번째문자출력
             }
         }
         Debug.Log(S[S.Length-1]);
     }*/

    private void Start()
    {
        string[] inputStrings = new string[] { "고승연", "고정인", "윤쫑씨" };
        //string resultString = string.Empty;

        foreach( string name in inputStrings)
        {
            Debug.Log($"{name[0]}{name[name.Length -1]}");
        }
    }
}















/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test35 : MonoBehaviour
{
    public string[] A;

    void Start()
    {
        for (int i = 0; i < A.Length; i++)
        {
            Debug.Log($"{A[i][0]}{A[i][A[i].Length - 1]}");
        }
    }
}*/