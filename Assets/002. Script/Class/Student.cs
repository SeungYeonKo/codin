using UnityEngine;

// 클래스 : 객체를 하나의 집합으로 묶는 단위, 틀
// 객체는 '만드는 과정'과 '사용하는 과정'이 필요하다
// 객체가 어떤 속성이 있고 어떤 기능(행위)을 하는지 설명하는 설계도

public class Student
{
    //속성(멤버 변수)
    //멤버변수 : 클래스에 소속된 변수
    //같은 클래스에 소속되어 있는 함수는 이 변수를 조건 없이 사용 가능
    public string Name;
    public int Age;
    private float _weight;   //디폴트값이 private값이지만 적어주어야한다. private값이면 언더바 + 소문자

    // 생성자 : new 키워드를 이용해서 객체를 생성할 때 자동으로 호출되는 함수
    // 반환 자료형을 안써주고, 클래스 이름과 동일하게 만든다
    // 주로 객체 생성과 동시에 속성(멤버변수)을 초기화할 때 사용한다
    public Student()
    {
        _weight = 50f;
    }
    public Student(string name, int age, float weight)
    {
        Name = name;
        Age = age;
        _weight = weight;
    }





    //행동(멤버 함수)
    //같은 클래스에 소속되어 있는 함수끼리는 조건 없이 호출 가능
    public void Speak()
    {
        Debug.Log($"안녕 내 이름은{Name}이고, 나이는{Age}살이야. ");
    }
    public void Highfive(Student otherStudent)
    {
        Debug.Log($"{Name}과 {otherStudent.Name}은 하이파이브를 했다! ");
    }
}

