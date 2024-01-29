
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test24 : MonoBehaviour
{//X보다 작은 수 출력하기

    public int[] A;            //정수를 입력 받을 배열 A
    public int X;               //기준이 되는 정수를 입력받을 X

    void Start()
    {
        string answer = "";

        for (int i = 0; i < A.Length; i++)  //A배열 전체를 순회함
        {
            if (A[i] < X)               //만약 배열A에서 X보다 작은 수가 있다면??
            {
                answer += A[i];
            }
        }
        Debug.Log(answer);      //출력해준다~~~~~~~~~~~~
    }
}
/*4. 숫자를 문자로 형변환

ToString() 메소드를 이용
 int intValue3 = 10;
        string stringValue3 = intValue3.ToString();
        Debug.Log($"stringValue3 : {stringValue3}");

*/

//1 10 4 9 2 3 8 5 7 6
//string[] studentNames = new string[3] { "고승연", "고정인", "고수연" };
/*for (int i = 0; i < studentNames.Length; i++)
        {
            Debug.Log(studentNames[i]);
        }*/
//스트링타입변수 선언 -> 별찍기처럼 출력

// answer += " ";