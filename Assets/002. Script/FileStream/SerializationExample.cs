using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //직렬화(Serialization)  :    객체를 파일형태로 저장하려면 직렬화를 거쳐야함
    //메모리에 저장된 객체를 파일에 저장하기 좋은 형태로 가공하는 것

    private void Start()
    {
        //테스트용 객체 생성
        Human human = new Human();
        human.Name = "고승연";
        human.Age = 24;

        //파일열기
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);

        //파일쓰기
        //객체를 파일로 쓸 때는 BinaryFormatter 클래스 사용
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, human);
        fs.Close();

        //파일 읽기
        //파일로부터 객체를 읽어 올때 똑같이 BinaryFormatter 클래스를 사용
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);
        Human h =bf.Deserialize(fs) as Human;
        if(h != null)
        {
            Debug.Log(h.Name);  
            Debug.Log(h.Age);  
        }
    }


}


[System.Serializable]           //직렬화 가능한  Human이다
public class Human
{
    public string Name;
    public int Age;
}