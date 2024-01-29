using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example24 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //첫번째 방법
        int[]  scores = new int[5] {100,99,98,97,96 };

        //두번째 방법 : 배열의 크기 생략(자동으로 크기가 들어감)
        int[] scores2 = new int[] { 100, 99, 98, 97, 96, 95 };

        //세번째 방법 : 두번째 방법에서 new연산자와 배열의 크기 모두 생략
        int[] scores3 = {100, 99, 98, 95, 97  };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
