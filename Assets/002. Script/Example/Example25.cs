using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example25 : MonoBehaviour
{//배열을 멤버 변수로 선언하면?

    public int[] n;

    private void Start()
    {
        Debug.Log(n.Length);   //배열의 길이를 알려줌

        int count = n.Length; //안에 있는 배열들을 다 출력해줌
        for (int i = 0; i < count; i++)
        {
            Debug.Log(n[i]);
        }
        

    }

    void Update()
    {
        
    }
}
