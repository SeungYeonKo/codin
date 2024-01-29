using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test30 : MonoBehaviour
{//서로 다른 나머지

    public int[] A;

    private void Start()
    {
        //나머지 값을 체크하기 위한 배열 생성
        bool[] checks = new bool[42];

        //1. 배열 A의 모든 값을 확인
        for(int i = 0; i < A.Length; i++) 
        {
            //2. 각 요소의 값을 42로 나눈 나머지 값 확인
            checks[A[i] % 42] = true;
        }

        //서로 다른 나머지가 몇 개 있는지 출력
        int count = 0;
        //3. checks 배열에서 true  개수를 구함
        foreach (bool check in checks)
        {
            if (check == true)
            {
                count++;
            }
        }
            Debug.Log(count);
        }
    }























/*  int div = 42;  //나누어줄 수
        int count = 0;  //count해줘야해서 초기ㅗ하
        int[] answer = new int[]  { };  //얜뭐임 -> 원소들 나누기 div값해서 그걸 저장하는 공간

        for (int i = 0; i < input.Length; i++)  //input배열 안에 들어있는 모든 수를 돌아줌
        {
            answer = input[i] % div;  //원소들 나누기 div값
            if (input[i] != answer)     //만약에 42로 나눈 값이 서로 다르다면
            {
                count++;        //갯수를 세준다

                Debug.Log(count);       //세어준 갯수를 출력한다
            }
        }*/

//질문
//input[i]가 의미하는 것
//input.Length는 그냥 배열이 가지고있는 원소의 갯수만 의미하는지

/*    int[] ans = new ans[] { };
    int div = 42;
    int count = 0;
        
        for(int i = 0; i<input.Length; i++)
        {
            ans = input[i] % div;
            if (input[i] != input[i])
            {
                count++;
            }
        }
        //그 다음 서로 다른 값이 몇 개 있는지 찾아 출력해 준다 -> count
        Debug.Log(ans);
    }*/
//입력받은 배열들의 원소를  42로 나눈 나머지를 구한다 -> %
/* for (int i = 0; i < box.Length; i++)
 {


     Debug.Log(box[i]);
 }*/


//그 다음 서로 다른 값이 몇 개 있는지 찾아 출력해 준다