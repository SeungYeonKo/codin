using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 보간 : 시작점과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율) -> 0 ~ 1 사이의 값
// 무언가를 부드럽게할 때 사용

// 구면 선형 보간(SLerp : Sphercial Linear Interpolation) -> 
// 직선 형태가 아닌 " 구면 " 형태로 값을 추론한다.
// 시작점과 종료점은 느리게 증가하고, 중간 지점은 빠르게 이동하는 특성
// -> 자연스러운 회전 로직에 많이 사용한다

public class SLerpExample : MonoBehaviour
{
    public Transform Start;
    public Transform End;

    // - 진행률 (0~1사이의 값) 
    private float _progress;

    public float duration = 3f;

    void Update()
    {
        _progress += Time.deltaTime / 3;
        // Vector3.Lerp(시작 좌표, 종료 좌표, 진행률)
        transform.position = Vector3.Slerp(Start.position, End.position, _progress);
    }
}
