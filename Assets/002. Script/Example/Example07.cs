using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example07 : MonoBehaviour
{

   public string nickname = "고승연";
   public int age = 23;
   public float height = 162.3f;
    
    void Start()
    {
        Debug.Log("이름 : " + nickname);
        Debug.Log("나이 : " + age);
        Debug.Log("키 : " + height);
    }

    void Update()
    {
        
    }
}

/*
  -멤버(변수) 접근 제한자 : 멤버 변수의 접근을 제한하기 위해 사용하는 키워드
        1.private : 클래스 내부에서만 접근 가능(default)
        2.public : 외부에서 자유롭게 접근 가능
*/