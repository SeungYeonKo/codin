using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample3 : MonoBehaviour
{
    private Coroutine _studyCoroutine;
    private Coroutine _teachCoroutine;

    void Start()
    {
        _studyCoroutine = StartCoroutine(Study_Coroutine());
        _teachCoroutine = StartCoroutine(Teach_Coroutine());
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // 코루틴 정지하는 방법 2.
            // 이 스크립트에서 속한 모든 코루틴을 중지시킨다
            //StopAllCoroutines();

            // 매개변수로 전달한 "특정" 코루틴을 중지시킨다
            StopCoroutine(_teachCoroutine);
        }
    }
    private IEnumerator Teach_Coroutine()
    {
        while (true)
        {
            yield return null;          // 한 프레임 쉰다(다음 프레임까지 대기)
            Debug.Log("강의중 . . .");
        }
        
    }

    private IEnumerator Study_Coroutine()
    {
        while (true)
        {
            yield return null;          // 한 프레임 쉰다(다음 프레임까지 대기)
            Debug.Log("공부중 . . .");
        }
    }
}
