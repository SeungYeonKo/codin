using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTest : MonoBehaviour
{//구조체는 new 키워드를 사용하지 않아도 변수를 선언/할당할 수 있다
    void Start()
    {/*//구조체 방법 : 
        Point point1;
        point1.X = 3;
        point1.Y = 7;
         Debug.Log($"x : {point1.X}, y : {point1.Y}");

        Point point2;
        point2.X = 4;
        point2.Y = 5;
        Debug.Log($"x : {point2.X}, y : {point2.Y}");
*/
        //클래스방법 : 
        Point point1 =  new Point(3 , 7);
        Debug.Log($"x : {point1.X}, y : {point1.Y}");

        Point point2 = new Point(4, 5);
        Debug.Log($"x : {point2.X}, y : {point2.Y}");

        /*point2 = point1;
        point2.X = 16;

        Debug.Log("-------------------변경후--------------------");

        Debug.Log($"x : {point1.X}, y : {point1.Y}");
        Debug.Log($"x : {point2.X}, y : {point2.Y}");
*/

    }
}
