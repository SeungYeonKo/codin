using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : MonoBehaviour
{//주사위 세개 (조건문 문제)
    int reward = 0;
    public int Dice1 = 3;
    public int Dice2 = 3;
    public int Dice3 = 6;

    void Start()
    {//같은 눈이 3개 나오면... = 조건문


        if (Dice1 == Dice2 && Dice2 == Dice3)  //첫번 째 조건 : 같은 눈이 세개 나오면
        {
           reward = 10000 + Dice1 * 1000;
        }
        else if(Dice1 == Dice2 || Dice2 == Dice3 || Dice3 == Dice1) //두번 째 조건 : 같은 눈이 2개만 나오는 경우 
        {
            if (Dice1 == Dice2)
            {
               reward = 1000 + Dice1 * 100;
            }
            else if (Dice2 == Dice3)
            {
               reward = 1000 + Dice2 * 100;

            }
            else if (Dice1 == Dice3)
            {
                reward = 1000 + Dice3 * 100;
            }
         }
        else  //남은 경우의 수는 '세 개 다 다르다' 이기 때문에 else만 써줌
        {
            if(Dice1>Dice2 && Dice1 > Dice3)
            {
                //Dice1 이 가장 크다
                reward = Dice1 * 100;
            }
           else if (Dice2 > Dice1 && Dice2 > Dice3)
            {
                //Dice2 가 가장 크다
                reward = Dice2 * 100;
            }
            else
            {
                //Dice3 이 가장 크다
                reward = Dice3 * 100;
            }
        }
        Debug.Log(reward);
    }

    void Update()
    {
        
    }
}
