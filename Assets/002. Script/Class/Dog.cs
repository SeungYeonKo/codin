using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string Name;
    public int Age;
    public string FurColor;
    public string Type;
    public float Weight;
    //private bool _GoOut;

    public Dog() //매개변수가 없는 생성자는 다른 생성자가 없을 경우 자동으로 생성된다
        {
       // _GoOut = false;
        }

    public Dog(string name, int age, string furcolor, string type, float weight, bool GoOut)
    {
        Name = name;
        Age = age;
        FurColor = furcolor;
        Type = type;
        Weight = weight;
        //_GoOut = true;
    }

    public void Run()
    {
        Debug.Log($"{Name}가 뛰고 있다 ");
    }
    public void Sleep()
    {
        Debug.Log($"{Name}가 자고 있다 ");
    }
    public void Bark()
    {
        Debug.Log($"{Name}가 짖고 있다 ");
    }
    public void Bring(Dog otherDog)
    {
        Debug.Log($"{Name}가 {otherDog.Name}를 물어왔다");
    }
    public void Bring(Cat otherCat)
    {
        Debug.Log($"{Name}가 {otherCat.Name}를 물어왔다");
    }
}


