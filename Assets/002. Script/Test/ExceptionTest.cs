using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionTest : MonoBehaviour
{
    // 예외란: 프로그램이 실행되는 동안 발생되는 오류를 의미(런타임 에러)
    // -> 테스트를 진행하면서 잡을 수 있다

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        bool result =TryGetComponent<Rigidbody2D>(out _rigidbody2D);
        if(_rigidbody2D != null )
        {
            _rigidbody2D.position = Vector2.zero;
        }
        else
        {
            Debug.Log("게임 오브젝트에 rigidbody2d 컴포넌트가 안달려있습니다");
        }
    }

    void Start()
    {
        // 1, NullReferenceException
        // 이 예외는 참조가 된 객체가  Null인데 이 객체의 멤버(변수, 함수)에 접근할 때 발생
        /* GameObject player = GameObject.Find("player");
         player.GetComponent<Rigidbody2D>();*/
        GameObject player = GameObject.Find("player");
        if (player != null) //해결 : 방어코드 if조건문을 사용하여 null검사를 한다
        {
            player.GetComponent<Rigidbody2D>();
        }

        // 2. IndexOutOfRangeException
        // 배열이나 리스트에서 유효하지 않은 인덱스에 접근할 때 발생
        /*int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
        Debug.Log(numbers[7]);*/
        int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
        int index = 7;
        //해결 : 유효범위 검사를 한다
        if(0<= index && index < numbers.Length)
        {
            Debug.Log(numbers[index]);
        }

        // 3. MissingReferenceException
        // 유니티에서 할당되지 않은 객체의 멤버에 접근하거나, 씬에서 삭제되었지만 여전히 그 객체를 참조하려고 할 때 발생
        // 비활성화된 게임 오브젝트에서 코루틴을 실행하려고 할 때도 발생
        /* GameObject monsterObject = GameObject.Find("Monster");
         DestroyImmediate(monsterObject);
         monsterObject.transform.position = Vector2.zero;*/
        
        //해결 1. 인스펙터 확인을 잘 하자
        //해결 2. null 검사를 하자
        GameObject monsterObject = GameObject.Find("Monster");
        DestroyImmediate(monsterObject);
        monsterObject.transform.position = Vector2.zero;

        // 4. DivideByZeroException
        // 정수 타입의 숫자를 0으로 나누려고 할 때 발생
        /*int health = 0;
        int maxHealth = 100;
        Debug.Log(maxHealth / health);*/

        int health = 0;
        int maxHealth = 100;
        //해결 : 0 검사를 잘하자
        if(health ==0) 
        {
            Debug.Log("0");
        }
        else
        {
            Debug.Log(maxHealth / health);
        }

        // 5. FormatException
        // 문자열을 형변환 하려고 할 때 데이터의 타입이 원하는 데이터 타입과 일치하지 않을 때
        /*string number = "O";   //대문자 O
        int number = int.Parse(numberString);
        Debug.Log(number);*/
    }
}
