using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Test08 : MonoBehaviour
{
    public int score;

    void Start()
    {
        /*if (90 <= score && score <= 100)
        {
            Debug.Log("A");
        }

         else if (80 <= score && score <= 89)
        {
            Debug.Log("B");
        }

         else if (70 <= score && score <= 79)
        {
            Debug.Log("C");
        }

        else if (60 <= score && score <= 69)
        {
            Debug.Log("D");
        }

        else  
        {
            Debug.Log("F");
        }*/



       /* switch (score/10)
        {
            case 9 : 
                {
                    Debug.Log("A");
                    break;
                }
            case 8:
                {
                    Debug.Log("B");
                    break;
                }
            case 7:
                {
                    Debug.Log("C");
                    break;
                }
            case 6:
                {
                    Debug.Log("D");
                    break;
                }
            default:
                {
                    Debug.Log("F");
                    break;
                }
        }*/
       switch(score)
        {
            case >= 90:
                {
                    Debug.Log("A");
                    break;
                }
            case >= 80:
                {
                    Debug.Log("B");
                    break;
                }
            case >= 70:
                {
                    Debug.Log("C");
                    break;
                }
            case >= 60:
                {
                    Debug.Log("A");
                    break;
                }
            default:
                {
                    Debug.Log("F");
                    break;
                }
        }
    }

    void Update()
    {

    }
}
