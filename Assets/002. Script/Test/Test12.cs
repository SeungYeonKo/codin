using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12 : MonoBehaviour
{//오븐시계
    public int Hour = 14;
    public int Min = 30;
    public int AddMin = 20;


    void Start()
    {
        int newHour = Hour;
        int newMin = Min + AddMin;

        //만약 분이 60분을 넘기면 
        if(newMin >= 60)
        {
            newHour += (newMin / 60);   //시간은 더해주고
            newMin = (newMin%60);   //분은 빼준다
        }
        if(newHour >= 24)
        {
            newHour -= 24;
        }

        Debug.Log($"{newHour} : {newMin}");


    }
}
