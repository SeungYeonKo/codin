using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test11 : MonoBehaviour
{//알람시계
    public int Hour; 
    public int Min;
    int AddMin = 40;
    

    void Start()
    {
        int newHour = Hour;
        int newMin = Min - AddMin;

        if (newMin >= 60)
        {
            newHour -= (newMin / 60);   //시간은 더해주고
            newMin = (newMin % 60);   //분은 빼준다
        }
        if (newHour >= 24)
        {
            newHour -= 24;
        }
        Debug.Log($"{newHour}:{newMin}");
    }
        

    
    void Update()
    {
        
    }
}

// H : M
// 0 <= H <=23
// 0 <= M <= 59
// 24시간표현사용
// 하루의 시작 0:0 끝 23:59

//H = H+1;
//M











/*switch (H <= 23)
        {
            case 1:
            {
                Debug.Log(H);
                break;
            }
        }*/