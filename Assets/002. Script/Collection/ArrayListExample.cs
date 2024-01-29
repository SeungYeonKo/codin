using System.Collections;                   //컬렉션
using System.Collections.Generic;     //제네릭컬렉션
using UnityEngine;                              

public class ArrayListExample : MonoBehaviour
{
    void Start()
    {
        // 기존 배열의 단점
        // 1. 배열을 선언할 때 지정한 배열의 크기를 변경할 수 없다
        //string[] students = new string [4]{ "민예진", "전민성", "이성민", "고승연" };
        //students[0] = "";

        // 2. 데이터를 배열에 추가하거나 삭제하는 경우 비효율적인 과정이 필요하다
        // (중간에 데이터를 삽입하거나 삭제할 경우 모든 데이터의 인덱스 변경이 불편하다)

        // -> 이런 단점을 해결하기 위해 '컬렉션' 사용
        // 데이터를 다루는 다양한 기능을 구조화하여 편하게 클래스로 구현해 놓은 것
        // ArrayList, HashTable, Queue, Stack

        // 컬렉션의 단점:
        // "박싱/언박싱"으로 인해 성능적인 문제가 발생한다

        // ArrayList : 필요에 따라 크기가 동적으로 변하는 배열
        // 특징 : 배열과 달리 크기를 지정할 필요가 없다
        // Add: 특정 자료형 뿐 아니라 여러 자료형의 데이터를 담을 수 있다

        // 사용 방법
        // 변수 선언
        ArrayList myList = new ArrayList();       //자료형   변수명       

        // 데이터 추가(Add)
        myList.Add("민예진");
        myList.Add("전민성");
        myList.Add("이성민");
        myList.Add("고승연");
        myList.Add(479);
        myList.Add(false);
        myList.Add(0.235f);             //박싱

        //인덱스를 이용한 데이터 조회
        Debug.Log(myList[0]);       //언박싱
        Debug.Log(myList[1]);
        Debug.Log(myList[2]);
        Debug.Log(myList[3]);
        Debug.Log(myList[4]);
        Debug.Log(myList[5]);
        Debug.Log(myList[6]);

        // 리스트 개수 속성
        Debug.Log(myList.Count);
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }

        // 삭제 -Remove, RemoveAt
        // - Remove(): 제거할 요소의 값을 매개변수로 전달
        // - RemoveAt() : 제거할 요소의 인덱스 순서를 매개변수로 전달
        myList.Remove("이성민");
        myList.RemoveAt(0);
        Debug.Log($"데이터의 개수 :{myList.Count}");
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }

        // 삽입 - Add
        // Add()는 데이터의 맨 끝에 추가
        // Insert()는 지정한 인덱스에 데이터를 삽입
        myList.Insert(0, "민예진");
        myList.Insert(3, "정수빈");            //기존 3번째 인덱스에 있던 '이성민' 대신 '정수빈'이 들어오고 한칸씩 데이터가 밀려 저장됨
        Debug.Log($"데이터의 개수 :{myList.Count}");
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }

        //뒤집기 - Reverse
        myList.Reverse();
        Debug.Log($"데이터의 개수 :{myList.Count}");
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }
    }
    void Update()
    {
        
    }
}
