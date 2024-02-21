using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 보간 : 시작점과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율) -> 0 ~ 1 사이의 값
// 무언가를 부드럽게할 때 사용

// Curve(곡선) : 연속적인 점의 집합
public class CurveExample : MonoBehaviour
{
    // 보간을 시각적으로 볼 수 있는 그래프 에디터
    public AnimationCurve Curve;
    public Transform Start;
    public Transform End;

    public bool _isRight;

    // - 진행률 (0~1사이의 값) 
    private float _progress;

    public float duration = 3f;

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
        transform.position = Vector3.Slerp(Start.position, End.position, Curve.Evaluate(_progress));
    }
}
