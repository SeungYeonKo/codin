using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 베지어 곡선 : 여러 점들 사이를 부드럽게 연결해주는 곡선
// Lerp는 두 점 사이의 직선 경로를 따라 간단한 보간을 제공하는 반면,
// Bezier는 여러 점사이의 복잡한 곡선 경로를 생성할 수 있다.

public class BezierCurveExample: MonoBehaviour
{
    public Transform Start;
    public Transform Center;
    public Transform End;

    // - 진행률 (0~1사이의 값) 
    private float _progress;
    

    public float duration = 3f;

    void Update()
    {
        _progress += Time.deltaTime / duration;
        // Vector3.Lerp(시작 좌표, 종료 좌표, 진행률)
        transform.position = BezierLerp(Start.position, Center.position, End.position, _progress);
    }

    private Vector3 BezierLerp(Vector3 start, Vector3 center, Vector3 end, float progress)
    {
        // 1. 시작점과 중간점 사이의 보간 위치를 구한다
        Vector3 m0 = Vector3.Lerp(start, center, progress);
        // 2. 중간점과 끝점 사이의 보간 위치를 구한다
        Vector3 m1 = Vector3.Lerp(center, end, progress);
        // 3. m0과 m1 사이의 보간 위치를 구한다
        Vector3 finalPoint = Vector3.Lerp(m0, m1, progress);

        return finalPoint;
    }
}
