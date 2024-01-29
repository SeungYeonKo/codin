using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class AnimalTest : MonoBehaviour
{
    //고양이 강아지
    void Start()
    {
        Cat cat1 = new Cat("나비",1,"치즈","노르웨이숲",5.2f,false);
        Cat cat2 = new Cat("딸기",3,"블루블랙","러시안블루",4.3f,true);
    
        Dog dog1 = new Dog("아롱이", 4, "연한갈", "웰시코기", 7.2f, false);
        Dog dog2 = new Dog("으억이", 1, "검정", "치와와", 3.4f, false);
       

        Debug.Log($"이름 : {cat1.Name}");
        Debug.Log($"{cat1.Age}살");
        Debug.Log($"{cat1.FurColor}색");
        Debug.Log(cat1.Type);
        Debug.Log($"{cat1.Weight}kg");

        Debug.Log($"이름 :{cat2.Name}");
        Debug.Log($"{cat2.Age}살");
        Debug.Log($"{cat2.FurColor}색");
        Debug.Log(cat2.Type);
        Debug.Log($"{cat2.Weight}kg");

        cat1.Run();
        cat1.Sleep();
        cat1.Crying();
        cat1.Grooming(cat2);            //나비 -> 딸기
        cat1.Grooming(dog1);                  //나비 -> 아롱이

        cat2.Run();
        cat2.Sleep();
        cat2.Crying();
        cat2.Grooming(cat1);            //딸기 -> 나비
        cat2.Grooming(dog2);            //딸기 -> 으억이
       
        Debug.Log($"이름 : {dog1.Name}");
        Debug.Log($"{dog1.Age}살");
        Debug.Log($"{dog1.FurColor}색");
        Debug.Log(dog1.Type);
        Debug.Log($"{dog1.Weight}kg");

        Debug.Log($"이름 :{dog2.Name}");
        Debug.Log($"{dog2.Age}살");
        Debug.Log($"{dog2.FurColor}색");
        Debug.Log(dog2.Type);
        Debug.Log($"{dog2.Weight}kg");

        dog1.Run();
        dog1.Sleep();
        dog1.Bark();
        dog1.Bring(dog2);              //아롱이 -> 으억이
        dog1.Bring(cat1);                      //아롱이 -> 나비

        dog2.Run();
        dog2.Sleep();
        dog2.Bark();
        dog2.Bring(dog1);               //으억이 -> 아롱이
        dog2.Bring(cat2);                       //으억이 -> 딸기
    }
}
