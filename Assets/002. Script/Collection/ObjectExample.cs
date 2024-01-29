using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExample : MonoBehaviour
{//박싱언박싱 
    void Start()
    {
        // 컬렉션(ArrayList, HashTable)의 단점:
        // "박싱/언박싱"으로 인해 성능적인 문제가 발생한다
        // 이러한 단점이 있어 잘 사용하지 않음


        // C#의 모든 자료형은 System.object를 상속받는다
        // 어떤 데이터든 다룰 수 있는 타입
        //object = 클래스 : 참조형(실제 데이터가 저장되어 있는 위치(주소값)을 참조한다)

        // 힙
        object intValue = 31;                               
        object floatValue = 150.1f;
        object boolValue = false;

        // 스택
        // 형변환
        int valueInt = (int)intValue;                    
        float valueFloat = (float)floatValue;
        bool valueBool = (bool)boolValue;

        // 형변환의 형변환
        intValue = (object)valueInt;
        floatValue = (object)valueFloat;
        boolValue = (object)valueBool;

        
    }
}
