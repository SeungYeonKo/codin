using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{
    public int weight;
    public int height;
   
    void Start()
    {
       
        float BMI =(height * height) /  weight   ;
        Debug.Log(BMI) ;
      
    }

    
}
