using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物1號")]
    public Enemy monster1;

    [Header("怪物2號")]
    public Enemy monster2;

    private void Start()
    {
        print("怪物1號的魔力:" + monster1.magic);
        print("怪物二號的裝備名稱:" + monster2.equipment);


        monster1.blood = 100;
        monster2.blood = 300;
        monster1.defense = 50;
        monster1.weapon = "木棍";
        monster2.weapon = "短刀";
        monster1.key = true;
        monster2.treasure = true;
    }
}
