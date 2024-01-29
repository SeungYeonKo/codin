using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextLoadExample : MonoBehaviour
{    
    void Start()
    {
        TextAsset textAsset = Resources.Load("students") as TextAsset;
       // Debug.Log(textAsset.text);

        StringReader stringReader = new StringReader(textAsset.text);
        Debug.Log(stringReader.ReadToEnd());                    //ReadToEnd : 끝까지 읽기, ReadLine : 한줄씩 읽기
        while (true)
        {
            string line = stringReader.ReadLine();
            //Debug.Log(line);
            if (line == null)
            {
                break;
            }
            string[] data = line.Split(',');
            string name = data[0];
            int age = int.Parse(data[1]);
            float birth = float.Parse(data[2]); 
            Debug.Log($"{name}{age}의 생일 {birth}");
        }
    }
}
