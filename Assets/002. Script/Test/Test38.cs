using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test38 : MonoBehaviour
{
    // 38. 알파벳 찾기
    public string InputString;
   
    void Start()
    {
       for (char i = 'a' ; i <= 'z'; i++)               //
        {
            int result = InputString.IndexOf(i);
            Debug.Log(result);
        }
    }
}























// Debug.Log(alphabet[0]); -> a 가 출력 

/*public class Test38 : MonoBehaviour
{
    // 38. 알파벳 찾기
    public string W;
    char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    void Start()
    {
        char[] wordArr = W.ToArray();
        for (int i = 0; i < alphabet.Length; i++)
        {
            Debug.Log(wordArr[i]);
        }
    }
}*/


/*public class Test38 : MonoBehaviour
{
    // 38. 알파벳 찾기

    public string W;
    char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    void Start()
    {
        char[] wordArr = W.ToArray();
        alphabet = wordArr;

        for (int i = 0; i < alphabet.Length; i++)
        {
            if (alphabet == wordArr)
            {
                Debug.Log(alphabet[i]);
            }
            *//* else if(alphabet != wordArr)
             {
                 Debug.Log("-1");
             }*//*
        }
    }
}*/