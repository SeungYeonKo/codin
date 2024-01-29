using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public string Name;
    public int Age;
    public string FurColor;
    public string Type;
    public float Weight;
    //private bool _water;

    public Cat() 
    {
        //_water = true;
    }//매개변수가 없는 생성자는 다른 생성자가 없을 경우 자동으로 생성된다


    public Cat(string name, int age, string furcolor, string type, float weight, bool water)
    {
        Name = name;
        Age = age;
        FurColor = furcolor;
        Type = type;
        Weight = weight;
        //_water = true;
    }
    public void Run()
    {
        Debug.Log($"{Name}가 뛰고 있다 ");
    }
    public void Sleep()
    {
        Debug.Log($"{Name}가 자고 있다 ");
    }
    public void Crying()
    {
        Debug.Log($"{Name}가 울고 있다 ");
    }
    public void Grooming(Cat otherCat)
    {
        Debug.Log($"{Name}가 {otherCat.Name}를 그루밍하고 있다 ");
    }
    public void Grooming(Dog otherDog)
    {
        Debug.Log($"{Name}가 {otherDog.Name}를 그루밍하고 있다 ");
    }
}
