using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Character : MonoBehaviour
{
    [Header("이름")]
    public string Name = "시즈땡크";

    [Header("직업")]
    public string Job = "메카닉";

    [Header("길드")]
    public string guild = "순애";

    [Header("인기도")]
    public int Popular = 513;

    [Header("스탯 공격력")]
    public string StPower = "1억 0738만 6741~ 1억 2486만 8301";

    [Header("HP")]
    public int HP = 74884;

    [Header("MP")]
    public int MP = 37332;

    [Header("좋아하는 음식")]
    public string FavoriteFood = "마라탕";

    [Header("좋아하는 것")]
    public string FavoriteThing = "집";


    [Header("상세스탯")]
    //debug.log(StPower);
    public float DetailSt = 10.223f;
    public float Demage = 107.00f;
    public float FinalDemage = 52.90f;
    public string AttackSpeed = "8단계";
    public string RegendaryAbility = "패시브 스킬 레벨이 1 증가 (액티브 혼 ... 보스 몬스터 공격 시 데미지 10% 증가 상태 이상에 걸린 대상 공격시 데미지 증가";


    void Start()
    {
        Debug.Log("이름 : " + Name);
        Debug.Log("직업 : " + Job);
        Debug.Log("길드 : " + guild);
        Debug.Log("인기도 : " + Popular);
        Debug.Log("스탯파워 : " + StPower);
        Debug.Log("HP : " + HP);
        Debug.Log("MP : " + MP);
        Debug.Log("스탯파워 : " + StPower);
        Debug.Log("스탯 공격력 : " + DetailSt);
        Debug.Log("데미지 : " + Demage);
        Debug.Log("최종데미지 : " + FinalDemage);
        Debug.Log("공격속도 : " + AttackSpeed);
        Debug.Log("레전더리 어빌리티 : " + RegendaryAbility);
        Debug.Log("좋아하는 음식 : " + FavoriteFood);
        Debug.Log("좋아하는 것 : " + FavoriteThing);
    }

    void Update()
    {
        
    }
}
