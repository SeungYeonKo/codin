using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    void Start()
    {
        //UnityEngine.Random 클래스 : 난수 생성과 관련있는 클래스
        // 난수 : 정의된 범위내에서 무작위로 추출된 수 (=랜덤값)

        UnityEngine.Random.InitState(13);   //초기 시드 값 13으로 초기화

        Debug.Log(UnityEngine.Random.Range(0, 100));

        //Range 정의 (minInclusive : 포함한다 / maxExclusive : 포함하지 않는다)
        /*public static int Range(int minInclusive, int maxExclusive)
        {
            return RandomRangeInt(minInclusive, maxExclusive);
        }*/
    }

    void Update()
    {
        
    }
}
