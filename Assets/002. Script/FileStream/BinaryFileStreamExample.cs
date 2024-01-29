using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//바이너리파일의 장점 : 컴퓨터는 데이터를 0과 1 같은 바이너리 형태로 처리하므로 
//Binary를 사용하면 메모리를 좀 더 효율적으로 사용하고, 속도도 더 빠르다
public class BinaryFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // [ 파일 열기 ]
        // 매개변수
        // 1. 어떤 파일? (파일의 경로)
        // 2. 어떻게 다룰거냐? (파일의 모드)
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        //FileMode.Create : 파일이 없다면 새로 생성해주고, 있으면 덮어씌운다
        // .dat : 데이터(data)의 약어로 사용자가 정의한 데이터가 들어있는 파일의 확장자

        // [ 파일 쓰기 ]
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write("Hello World ");      
        bw.Write(4789);
        bw.Close();

        // [ 파일 읽기 ]
         fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);
        BinaryReader br = new BinaryReader(fs);
        Debug.Log(br.ReadString());
        Debug.Log(br.ReadInt32());

        br.Close();
    }
}
