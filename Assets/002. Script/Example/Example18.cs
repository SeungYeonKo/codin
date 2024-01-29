using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example18 : MonoBehaviour
{//분기문
    void Start()
    {
    //선택한 주문 번호에 따라 다른 음료수를 출력
    // 1번 선택 : 콜라
    // 2번 선택 : 사이다
    // 그 외 : 물
    
        int orderNumber = 3;

        switch(orderNumber)
        {
            case 1:
            {
                 Debug.Log("콜라");
                 break;
            }
            case 2:
            {
                Debug.Log("사이다");
                break;
            }
            default:
            {
                Debug.Log("물");
                break;
            }
        }
    }

    void Update()
    {
        
    }
}
