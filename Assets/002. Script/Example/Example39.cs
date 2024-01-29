using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example39 : MonoBehaviour
{//중요: ref 레퍼런스(call by reference 참조에 의한 호출)
   //전에는 call by value : 값에 의한 호출

   void Swap(ref int num1, ref int num2)
    {
        int tempNum = num1;
        num1 = num2;
        num2 = tempNum;
    }
    
    //ref키워드는 함수 내부에서 원본 변수의 값을 수정하지 않아도 되지만
    //out키워드는 함수 내부에서 무조건 원본 변수의 값을 수정해야 한다. 
    //out키워드는 ref와 비슷하지만 개발자의 실수를 줄여준다
    /*void Test(out int num)
    {
        num = 3;
    }*/

    void Start()
    {
        int num1 = 3;
        int num2 = 9;

      
        Debug.Log($"바뀌기 전 : num1={num1}, num2={num2}");

        Swap(ref num1, ref num2);

        Debug.Log($"바뀐 후 : num1={num1}, num2={num2}");

        //Test(out num1);
    }
    //ref : 레퍼런스(참조)
    //ref를 사용해주면 값만가져오는것이랑 달리 ref가 붙은 곳에 직접 접근해줌 = 다른 변수를 참조(c언어 = 포인터)

    void Update()
    {
        
    }
}
/* int num3;
            num3 = num1;
            num1 = num2;
            num2 = num3;
==

 int tempNum = num1;
        num1 = num2;
        num2 = tempNum;
*/      

//out :  무조건 원본 변수의 값을 강제로 바꿔줘야함  / -> 키워드 out 을 사용하면 실수를 줄여준다


//ref ; 변수의 값을 바꾸지 않아도 상관이 없음