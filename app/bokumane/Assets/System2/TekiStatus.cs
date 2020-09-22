using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TekiStatus : MonoBehaviour {

    public int TekiAttack;
    public int TekiHp;
    public int FullTekiHp;
    public int TekiAttack1;
    public int TekiHp1;
    public int TekiAttack2;
    public int TekiHp2;
    public int TekiAttack3;
    public int TekiHp3;

    private DungeonData1 dungeon1;   //ダンジョンデータの読み込み
    private DungeonData2 dungeon2;
    private DungeonData3 dungeon3;
    private DungeonData4 dungeon4;
    private DungeonData5 dungeon5;

    public int PostTekiAttack()
    {
        return TekiAttack;
    }
    public int PostTekiHp()
    {
        return TekiHp;
    }

    public void TekiStatusin()
    {
        if (Dungeon.DUNGEON == 1)   //ダンジョンデータの読み込み
        {
            dungeon1 = GetComponent<DungeonData1>();

            TekiAttack1 = dungeon1.TekiAttack1;
            TekiHp1 = dungeon1.TekiHp1;
            TekiAttack2 = dungeon1.TekiAttack2;
            TekiHp2 = dungeon1.TekiHp2;
            TekiAttack3 = dungeon1.TekiAttack3;
            TekiHp3 = dungeon1.TekiHp3;
        }
        else if(Dungeon.DUNGEON == 2)
        {
            dungeon2 = GetComponent<DungeonData2>();

            TekiAttack1 = dungeon2.TekiAttack1;
            TekiHp1 = dungeon2.TekiHp1;
            TekiAttack2 = dungeon2.TekiAttack2;
            TekiHp2 = dungeon2.TekiHp2;
            TekiAttack3 = dungeon2.TekiAttack3;
            TekiHp3 = dungeon2.TekiHp3;
        }
        else if (Dungeon.DUNGEON == 3)
        {
            dungeon3 = GetComponent<DungeonData3>();

            TekiAttack1 = dungeon3.TekiAttack1;
            TekiHp1 = dungeon3.TekiHp1;
            TekiAttack2 = dungeon3.TekiAttack2;
            TekiHp2 = dungeon3.TekiHp2;
            TekiAttack3 = dungeon3.TekiAttack3;
            TekiHp3 = dungeon3.TekiHp3;
        }
        else if (Dungeon.DUNGEON == 4)
        {
            dungeon4 = GetComponent<DungeonData4>();

            TekiAttack1 = dungeon4.TekiAttack1;
            TekiHp1 = dungeon4.TekiHp1;
            TekiAttack2 = dungeon4.TekiAttack2;
            TekiHp2 = dungeon4.TekiHp2;
            TekiAttack3 = dungeon4.TekiAttack3;
            TekiHp3 = dungeon4.TekiHp3;
        }
        else if (Dungeon.DUNGEON == 5)
        {
            dungeon5 = GetComponent<DungeonData5>();

            TekiAttack1 = dungeon5.TekiAttack1;
            TekiHp1 = dungeon5.TekiHp1;
            TekiAttack2 = dungeon5.TekiAttack2;
            TekiHp2 = dungeon5.TekiHp2;
            TekiAttack3 = dungeon5.TekiAttack3;
            TekiHp3 = dungeon5.TekiHp3;
        }

        if (Battle.battlecount == 0)  //バトルごとの敵ステータス読み込み
        {
            TekiAttack = TekiAttack1;
            TekiHp = TekiHp1;
            FullTekiHp = TekiHp1;
        }
        else if (Battle.battlecount == 1)
        {
            TekiAttack = TekiAttack2;
            TekiHp = TekiHp2;
            FullTekiHp = TekiHp2;
        }
        else if (Battle.battlecount == 2)
        {
            TekiAttack = TekiAttack3;
            TekiHp = TekiHp3;
            FullTekiHp = TekiHp3;
        }
    }
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
