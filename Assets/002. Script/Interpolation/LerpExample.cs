using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 보간 : 시작점과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율) -> 0 ~ 1 사이의 값
// 무언가를 부드럽게할 때 사용

// 선형 보간(Lerp : Linear Interpolation) -> 직선
// "직선" : 균일한 속도로 이동시키거나 회전시킬 때 사용

public class LerpExample : MonoBehaviour
{
    public Transform Start;
    public Transform End;

    // - 진행률 (0~1사이의 값) 
    private float _progress;
    private bool _isRight = false;

    public float duration=3f;

    void Update()
    {
        if (_isRight)
        {
            _progress += Time.deltaTime / duration;
        }
        else
        {
            _progress -= Time.deltaTime / duration;
        }
        if (_progress > 1)
        {
            _progress = 1;
            _isRight = false;
        }
        if (_progress < 0)
        {
            _progress = 0;
            _isRight = true;
        }
        // Vector3.Lerp(시작 좌표, 종료 좌표, 진행률)
        transform.position = Vector3.Lerp(Start.position, End.position, _progress);
    }
}
