using UnityEngine;

public class Enemy : MonoBehaviour
{
    //血量
    [Header("血量"),Range(50,500)]
    [Tooltip("怪物的血量")]
    public int blood ;

    //魔力
    [Header("魔力"), Range(10, 100)]
    [Tooltip("怪物的魔力")]
    public int magic = 100 ;

    //移動速度
    [Header("能力值"),Range(1, 50.5f)]
    public float movingSpeed = 10.5f ;

    //攻擊力
    [Range(20,200)]
    public int attack = 50 ;

    //防禦力
    [Range(0,100)]
    public int defense ;

    //武器名稱
    [Header("裝備")]
    public string weapon ;
    //裝備名稱
    public string equipment =  "皮衣";

    //是否帶有鑰匙
    [Header("其他資料")]
    [Tooltip("怪物是否帶有鑰匙")]
    public bool key = false;

    //是否掉落寶物
    [Tooltip("怪物是否帶有寶物")]
    public bool treasure = false ;
}
