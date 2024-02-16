using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CoroutineExample2 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Timer_Coroutine(3));
    }
    private IEnumerator Timer_Coroutine(float delayTime)
    {
        /*  //주어진 시간만큼 대기
          yield return new WaitForSeconds(delayTime);

          Debug.Log("딩동댕도오옹오오오옹ㅇ오옹오");

          yield return new WaitForSeconds(delayTime);

          Debug.Log("동딩댕동딩댕ㅇ동동딩댕동동댕동딩");*/

        int count = 10;
        while(true)   //무한하게 돌면서 3초마다 반복됨
        {
            yield return new WaitForSeconds(delayTime);

            Debug.Log("딩동댕도오옹오오오옹ㅇ오옹오");

            // 취소하는 방법 1. 
            count--;
            if(count <= 0)
            {
                yield break;
            }
        }
    }
}
