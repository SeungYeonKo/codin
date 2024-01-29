using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example17 : MonoBehaviour
{
    //내가한거
    /*//입력을 받아야 하기 때문에 ID,PW 와 같은 이름을 사용할 수 없음
    public string Id;
    public string Password;

    //변하지 않는 상수로 아이디와 비밀번호를 지정 
    const string ID = "rhtmddus";
    const string PASSWORD = "0121";

    void Start()
    {
        //1. ID가 다르면 "존재하지 않는 ID입니다." 출력
        //2. ID는 같으나 비밀번호가 다르면 "비밀번호가 틀렸습니다" 출력
        //3. ID와 비밀번호가 모두 같으면 "로그인 성공했습니다" 출력

        if (Id == ID && Password == PASSWORD)
        {
            Debug.Log("로그인에 성공했습니다!");
        }
        else if (Id != ID && Password != PASSWORD)
        {
            Debug.Log("존재하지 않는 ID입니다");
        }
        else if (Id == ID || Password != PASSWORD)
        {
            Debug.Log("비밀번호가 틀렸습니다");
        }
        else if (Id != ID || Password == PASSWORD)
        {
            Debug.Log("존재하지 않는 ID입니다");
        }
*/
    //강사님의 답
    //입력을 받아야 하기 때문에 ID,PW 와 같은 이름을 사용할 수 없음
    //입력을 받아야 하기 때문에 ID,PW 와 같은 이름을 사용할 수 없음
    public string Id;
    public string Password;

    //변하지 않는 상수로 아이디와 비밀번호를 지정 
    const string ID = "rhtmddus";
    const string PASSWORD = "0121";

    void Start()
    {
        //1. ID가 다르면 "존재하지 않는 ID입니다." 출력
        //2. ID는 같으나 비밀번호가 다르면 "비밀번호가 틀렸습니다" 출력
        //3. ID와 비밀번호가 모두 같으면 "로그인 성공했습니다" 출력
        if (Id != ID) //만약: ID가 다르면
        {
            if (Password != PASSWORD)
            {
                Debug.Log("비밀번호가 틀렸습니다");
            }
            else
            {
                Debug.Log("로그인 됐습니다.");
            }
        }
            Debug.Log("존재하지 않는 ID입니다.");
        }
     }
 
 
