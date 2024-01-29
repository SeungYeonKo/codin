using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentTest : MonoBehaviour
{
    void Start()
    {
        //객체를 만들 때는 클래스를 선언해 주어야 함
        Student student1 = new Student("전민성", 30, 32.5f);
        //student파일에 public을 만들어주어야 사용이 가능
        student1.Speak();

        Student student2 = new Student();
        student2.Name = "이성민";
        student2.Age = 25;
        student2.Speak();

        student1.Highfive(student2);

        Student student3 = null;            //오류가뜸 NullReferenceException 
        //null : 사전적으로 존재하지 않는다. 비어있다.
        //가장 빈번하게 오류를 일으키는 원인 중 하나
        //student3.Speak(); 

        student3 = student2;
        student3.Name = "김예은";
        Debug.Log(student2.Name);     //이성민 vs 김예은   => '김예은' 출력


    }
}
