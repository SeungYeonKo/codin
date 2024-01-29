using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example38 : MonoBehaviour
{//가변 길이 매개 변수
 //-> 매개 변수 개수가 유연하게 변한다.
/*    int Add (int num1, int num2) 
    {
        return Add (num1, num2);
    }*/

    int Add(params int[] nums)     //매개변수가 영어로 parameter . int앞에 붙이는 것은 문법이기때문에 외워야함
    {
        int sum = 0;

        for(int i=0; i<nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    void Start()
    {
        Add(1);
        Add(1,2);
        Add(1,5,2);

        Debug.Log(Add(1,2));
    }

    void Update()
    {
        
    }
}
