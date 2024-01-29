using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

 public class People
    {
    //캡슐화:
    //데이터와 데이터를 처리하는 행위를 하나로 묶는 것
    //먼저 속성을 은닉화 하고 행위를 통해 속성을 접근/수정하게 함으로써
    //잘못된 접근이나 의도치 않는 갓으로 변하는 보호 효과를 누린다
    //은닉화
    //은닉화 : 객체의 속성을 외부에서 직접 접근하지 못하도록 제한하는 개념
    private string Name; 
    private int Age;

    // 프로퍼티 : 속성이라는 뜻으로 변수의 값을 외부에서 접근할 수 있도록 하면서
    // 동시에 캡슐화를 지원하는 C#의 기능이다
    // -Get 접근자 : 멤버 변수로부터 값을 읽어온다
    // -Set 접근자 : 멤버 변수에 값을 할당한다
    private float _height;
    public float Height
    {
        get     //프로퍼티 내부에  get만 지정하면 읽기 전용
        {
            return _height;
        }
        set     //프로퍼티 내부에 set만 지정하면 쓰기 전용
        {
            if(value < 0)
            {
                return;
            }
            _height = value;    //value 키워드는 set접근자의 매개 변수
        }
    }

    private string _mbti;
    public string MBTI
    {
        get
        {
            return _mbti;
        }
        set
        {
            if(value.Length != 4)
            {
                return;
            }
           _mbti = value;
        }
    }
   
    public People(string name, int age, float height, string mbti) 
        {
            Name = name;
            Age = age;
            _height = height;
            MBTI = mbti;
        }

    //Get/Set   -> 데이터(속성)를 외부에서 읽고/수정 시 무결성이 깨질 수 있으므로
    //데이터는 메서드를 통해 읽고/수정하는게 좋다.
    public int GetAge()             // Get000 : 일반적으로 외부에서 객체의 데이터를 읽을 때 쓰는 메서드
    {
        //가공 후 외부로 전달할 수도 있다
        return Age;
    }
    public void SetAge(int age)     // Set000 : 일반적으로 외부에서 객체의 데이터를 수정할 때 쓰는 메서드
    {
        //검증을 통해 유효한 값만 수정할 수 있다

        if (Age  < 0)
        {
            Debug.Log("0살보다 작은 나이를 할당하려 한다");
            return;
        }
        Age = age;
    }

    public string GetName()
    {
        return Name;
    }
}

