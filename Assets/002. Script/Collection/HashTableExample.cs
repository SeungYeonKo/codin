using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableExample : MonoBehaviour
{
    void Start()
    {
        // HashTable : 키(key)와 값(value) 쌍으로 이루어진 데이터를 다룰 때 쓰는 구조
        // (기존에 데이터에 접근하기 위해 정수 인덱스를 사용하는 것이 아니라 
        // 타입이 자유로운 '키' 를 사용하는 것이다)
        //  int float string class  등 어떤 형식이든 사용 가능

        // 선언
        Hashtable myTable = new Hashtable();

        // 데이터 추가 테이블명.Add(키값, 데이터);
        myTable.Add("first", "민예진");
        myTable.Add("second", "전민성");
        myTable.Add("third", "이성민");
        myTable.Add(4, "고승연");
        myTable.Add(5.2f, 479);
        myTable.Add(false, 0);

        // 데이터 조회 : 선언한 키값을 이용해 데이터를 조회한다
        Debug.Log(myTable["first"]);
        Debug.Log(myTable["second"]);
        Debug.Log(myTable["third"]);
        Debug.Log(myTable[4]);
        Debug.Log(myTable[5.2f]);
        Debug.Log(myTable[false]);

        Debug.Log("--------------------------------------------");

        // 반복문을 이용한 조회
        for (int i = 0; i < myTable.Count; i++)
        {
            Debug.Log(myTable[i]);
        }

        Debug.Log("--------------------------------------------");

        foreach (var key in myTable.Keys)
        {
            Debug.Log(myTable[key]);
        }






        // 삭제
        myTable.Remove("first");    // first 키값을 갖는 데이터 삭제

        Debug.Log("--------------------------------------------");



        // 키가 있는지 검사
        // ContainsKey() 메서드를 이용해 해당 키를 사용하는 데이터가 있는지 검사
        if (myTable.ContainsKey("first"))
        {
            Debug.Log("first key 가 있습니다");
        }
        else
        {
            Debug.Log("first key 가 없습니다");
        }
    }

    void Update()
    {
        
    }
}
