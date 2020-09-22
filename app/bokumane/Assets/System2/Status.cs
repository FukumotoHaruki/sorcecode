using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Status : MonoBehaviour {
    public static int Hp;
    public static int Mp;
    public static int Attack;
    public static int Defense;

    public static int LEVEL;
    public static int EXP;

    public static int HP;
    public static int MP;
    public static int ATTACK;
    public static int DEFENSE;

    public int PostAttack()
    {
        return Attack;
    }
    public int PostHp()
    {
        return Hp;
    }
    public void StatusReset()
    {
        Hp = Avater.HP;
        Mp = Avater.MP;
        Attack = Avater.ATTACK;
        Defense = Avater.DEFENSE;
    }
    // Use this for init
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
