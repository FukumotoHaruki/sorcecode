using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour {
    private Slider Hpbar;
    private int FullHp;
    private int NowHp;
    private float Hp;
    private float hp;

    private Slider Mpbar;
    private int FullMp;
    private int NowMp;
    private float Mp;
    private float mp;

    private Slider TekiHpbar;
    private TekiStatus teki;
    private int TekiFullHp;
    private int TekiNowHp;
    private float TekiHp;
    private float tekihp;

    // Use this for initialization
    public void HPset(int x)
    {
        //Debug.Log("koko");
        NowHp = x;
        Hp = (float)NowHp/FullHp;
        //Debug.Log("ima"+NowHp);
        //Debug.Log("full"+FullHp);
        //Debug.Log("Hp" + Hp);
    }

    public void MPset(int y)
    {
        NowMp = y;
        Mp = (float)NowMp / FullMp;
    }

    public void TekiHPset(int z)
    {
        teki = GetComponent<TekiStatus>();
        TekiFullHp = teki.FullTekiHp;
        TekiNowHp = z;
        TekiHp = (float)TekiNowHp / TekiFullHp;
    }
    void Start () {
        FullHp = Avater.HP;
        FullMp = Avater.MP;

        Hpbar = GameObject.Find("Hpbar").GetComponent<Slider>();
        Mpbar = GameObject.Find("Mpbar").GetComponent<Slider>();
        TekiHpbar = GameObject.Find("TekiHpbar").GetComponent<Slider>();

        if(Battle.battlecount == 0)
        {
            Hp = 1;
            hp = 1;
            Mp = 1;
            mp = 1;
            TekiHp = 1;
            tekihp = 1;
        }
        else
        {
            NowHp = Status.Hp;
            hp = (float)NowHp / FullHp;
            Hp = (float)NowHp / FullHp;
            Hpbar.value = hp;

            NowMp = Status.Mp;
            mp = (float)NowMp / FullMp;
            Mp = (float)NowMp / FullMp;
            Mpbar.value = mp;

            TekiHp = 1;
            tekihp = 1;
        }
        //Debug.Log("hp" + hp);
    }

	// Update is called once per frame
	void Update () {
        if (hp > Hp)
        {
            hp -= 0.01f;
        }
        else if (hp < Hp)
        {
            hp += 0.01f;
        }
        Hpbar.value = hp;
        //Debug.Log("hp" + hp);
        if (mp > Mp)
        {
            mp -= 0.01f;
        }
        else if(mp < Mp)
        {
            mp += 0.01f;
        }
        Mpbar.value = mp;

        if (tekihp > TekiHp)
        {
            tekihp -= 0.01f;
        }
        TekiHpbar.value = tekihp;
    }

}
