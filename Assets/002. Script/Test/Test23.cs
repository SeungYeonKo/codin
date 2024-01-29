using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Test23 : MonoBehaviour
{
    public int[] n;
    public int v;

    void Start()
    {
        int count = 0;


        for (int i = 0; i < n.Length; i++)  //배열 전체를 순회함
        {
            if (n[i] == v)
            {
                count++;
            }
        }


        Debug.Log($"{count}개 있습니다");
    }

    void Update()
    {
        
    }
}

//Debug.Log($"배열의 길이 : {n.Length}");   //배열의 길이를 알려줌